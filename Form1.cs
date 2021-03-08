using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GoogleDirections;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.interfaces;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Locations
{
    public partial class Form1 : Form
    {
        private List<PointLatLng> _points;
        private List<PointLatLng> _returnPoints;
        public static List<string> address;
        public static List<string> returnAddress;
        public static Dictionary<PointLatLng, string> dic;
        public static Dictionary<PointLatLng, string> returnDic;
        public static Dictionary<string, int> sort;
        public static Dictionary<string, int> returnSort;
        public static List<AddressList> lst;
        public static List<AddressList> returnlst;
        public static string adres, name, gsm;
        Geocoder geocoder = new Geocoder("AIzaSyDAcL7WAkajwlmKlo54pK9nN3JIox0ocA4");
        PointLatLng start;
        PointLatLng current;
        PointLatLng minorPoint;
        PointLatLng deletedPoint;
        PointLatLng returnDeletedPoint;
        double totalKm;
        double returnTotalKm;
        double totalTime;
        double returnTotalTime;
        double minor;
        GMapOverlay markers;
        GMapOverlay routes;

        public static int counter;
        public static int returnCounter;
        public Form1()
        {
            InitializeComponent();
            _points = new List<PointLatLng>();
            _returnPoints = new List<PointLatLng>();
            address = new List<string>();
            returnAddress = new List<string>();
            current = new PointLatLng();
            dic = new Dictionary<PointLatLng, string>();
            returnDic = new Dictionary<PointLatLng, string>();
            sort = new Dictionary<string, int>();
            returnSort = new Dictionary<string, int>();
            lst = new List<AddressList>();
            returnlst = new List<AddressList>();
        }

        private void btnSaveStart_Click(object sender, EventArgs e)
        {
            var location = geocoder.Geocode(txtCurrentAddress.Text);
            current = GetAddressPoints(txtCurrentAddress.Text);
            start = current;
            map.DragButton = MouseButtons.Left;
            map.MapProvider = GMapProviders.BingMap;
            map.Position = new PointLatLng(current.Lat, current.Lng);
            map.MinZoom = 5;
            map.MaxZoom = 100;
            map.Zoom = 17;
            PointLatLng point = new PointLatLng(current.Lat, current.Lng);
            GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.arrow);
            GMapOverlay markers = new GMapOverlay("markers");
            markers.Markers.Add(marker);
            map.Overlays.Add(markers);
            txtCurrentAddress.Enabled = false;
            map.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GoogleMapProvider.Instance.ApiKey = "AIzaSyDAcL7WAkajwlmKlo54pK9nN3JIox0ocA4";
            markers = new GMapOverlay("markers");
            routes = new GMapOverlay("routes");
            map.ShowCenter = false;
        }

        private void btnAddress_Click(object sender, EventArgs e)
        {
            frmAddress frm = new frmAddress();
            frm.Show();
        }
        private void SetMarkers(PointLatLng point, int direction)
        {
            GMapMarker marker;
            if (direction == 0)
            {
                marker = new GMarkerGoogle(point, GMarkerGoogleType.lightblue);
                markers.Markers.Add(marker);
                map.Overlays.Add(markers);

            }
            else
            {
                marker = new GMarkerGoogle(point, GMarkerGoogleType.red);
                markers.Markers.Add(marker);
                map.Overlays.Add(markers);
            }
            map.Refresh();
        }
        private double Calculate(PointLatLng start, PointLatLng end)
        {
            var route = GoogleMapProvider.Instance.GetRoute(start, end, false, false, 15);
            return route.Distance;
        }
        private void RouteCreate(PointLatLng start, PointLatLng end, int direction)
        {
            MapRoute route;
            if (direction == 0)
            {
                route = GoogleMapProvider.Instance.GetRoute(start, end, false, false, 15);
                totalKm += route.Distance;
                totalTime += Convert.ToDouble(route.Duration.Split(' ')[0]);
                var r = new GMapRoute(route.Points, "Rota");
                r.Stroke.Width = 3;
                r.Stroke.Color = Color.DarkRed;
                routes.Routes.Add(r);
                map.Overlays.Add(routes);
            }
            else
            {
                route = GoogleMapProvider.Instance.GetRoute(start, end, false, false, 15);
                returnTotalKm += route.Distance;
                returnTotalTime += Convert.ToDouble(route.Duration.Split(' ')[0]);
                var r = new GMapRoute(route.Points, "RRota");
                r.Stroke.Width = 3;
                r.Stroke.Color = Color.DarkBlue;
                routes.Routes.Add(r);
                map.Overlays.Add(routes);
            }

        }
        private PointLatLng GetAddressPoints(string address)
        {
            var location = geocoder.Geocode(address);
            PointLatLng point = new PointLatLng();
            point.Lat = Convert.ToDouble(location.First().LatLng.Latitude.ToString());
            point.Lng = Convert.ToDouble(location.First().LatLng.Longitude.ToString());
            return point;
        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < address.Count; i++)
            {
                dic.Add(GetAddressPoints(address[i]), address[i]);
                
            }
            foreach (var item in address)
            {
                _points.Add(GetAddressPoints(item));
            }
            for (int i = 0; i < address.Count; i++)
            {

                deletedPoint = Foreach(_points, current, 0);
                current = deletedPoint;
                _points.Remove(deletedPoint);
            }
            map.Refresh();

            for (int i = 0; i < returnAddress.Count; i++)
            {
                returnDic.Add(GetAddressPoints(returnAddress[i]), returnAddress[i]);
            }
            foreach (var item in returnAddress)
            {
                _returnPoints.Add(GetAddressPoints(item));
            }
            for (int i = 0; i < returnAddress.Count; i++)
            {
                returnDeletedPoint = Foreach(_returnPoints, current, 1);
                current = returnDeletedPoint;
                _returnPoints.Remove(returnDeletedPoint);


            }
            RouteCreate(current, start, 0);
            map.Refresh();
            listBox1.DataSource = sort.OrderBy(kp => kp.Value)
                                      .Select(kp => kp.Key)
                                      .ToList();
            listBox2.DataSource = returnSort.OrderBy(kp => kp.Value)
                                  .Select(kp => kp.Key)
                                  .ToList();

            lblStatus.Text = $"Toplam Km : {totalKm} km ";
            lblReturnStatus.Text = $"Toplam Km : {returnTotalKm} km ";
            lblStatus.Visible = true;
            lblReturnStatus.Visible = true;
        }


        private PointLatLng Foreach(List<PointLatLng> list, PointLatLng current, int direction)
        {
            minor = 0;
            foreach (var item in list)
            {
                if (minor == 0 || (minor == 0 || minor > Calculate(current, item)))
                {
                    minor = Calculate(current, item);
                    minorPoint = item;
                }

            }
            string value = dic.Where(q => q.Key == minorPoint).Select(q => q.Value).SingleOrDefault();
            string returnValue = returnDic.Where(q => q.Key == minorPoint).Select(q => q.Value).SingleOrDefault();
            if (direction == 0)
            {
                counter++;
                sort.Add(counter.ToString() + " - " + value, counter);
         

            }
            else
            {
                returnCounter++;
                returnSort.Add(returnCounter.ToString() + " - " + returnValue, returnCounter);

            }
            SetMarkers(minorPoint, direction);
            RouteCreate(current, minorPoint, direction);
            return minorPoint;
        }
        private void btnReturnAddress_Click(object sender, EventArgs e)
        {
            frmDonus frm = new frmDonus();
            frm.Show();
        }
        int i = 0;
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            i++;
            if (i >= 2)
            {
                string aa = listBox1.SelectedValue.ToString().Substring(4);
                var element = lst.Where(q => q.address == aa).Select(q => q).SingleOrDefault();
                adres = element.address;
                name = element.name;
                gsm = element.gsm;
                frmShowDialog frm = new frmShowDialog();
                frm.Show();
            }
        }
        int j = 0;

        private void btnExport_Click(object sender, EventArgs e)
        {
            Export();
            MessageBox.Show("Masaüstünde Rapor.pdf adında çıktı oluşturuldu.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            j++;
            if (j >= 2)
            {
                string aa = listBox2.SelectedValue.ToString().Substring(4);
                var element = returnlst.Where(q => q.address == aa).Select(q => q).SingleOrDefault();
                adres = element.address;
                name = element.name;
                gsm = element.gsm;
                frmShowDialog frm = new frmShowDialog();
                frm.Show();
            }
        }
        public void Export()
        {

            Document doc = new Document(PageSize.LETTER, 30, 30, 50, 50);
            BaseFont baseFont = BaseFont.CreateFont("C:\\Windows\\Fonts\\Arial.ttf", "windows-1254", true);
            iTextSharp.text.Font fontNormal = new iTextSharp.text.Font(baseFont, 14);
            var desktopFolder = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            var fullFileName = Path.Combine(desktopFolder, "Rapor.pdf");
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(fullFileName, FileMode.OpenOrCreate)) ;
            wri.SetLanguage("tr-TR");
            wri.ClearTextWrap();
            doc.Open();
            Paragraph p = new Paragraph("İZLENECEK ROTA",fontNormal);
            doc.Add(p);
            p = new Paragraph("GİDİŞ YOLU \n", fontNormal);
            doc.Add(p);
            foreach (var item in sort)
            {
                p = new Paragraph($"{item.Key} ", fontNormal);
                doc.Add(p);
                var element = lst.Where(q => q.address == item.Key.Substring(4)).Select(q => q).FirstOrDefault();
                p = new Paragraph($"İsim : {element.name} Gsm: {element.gsm }", fontNormal);
                doc.Add(p);
            }

            p = new Paragraph("DÖNÜŞ YOLU ", fontNormal);
            doc.Add(p);
            foreach (var item in returnSort)
            {
                p = new Paragraph($"{item.Key}", fontNormal);
                doc.Add(p);
                var element = returnlst.Where(q => q.address == item.Key.Substring(4)).Select(q => q).FirstOrDefault();
                p = new Paragraph($"İsim : {element.name} Gsm: {element.gsm }", fontNormal);
                doc.Add(p);
            }
            doc.Close();
        }

    }
}
