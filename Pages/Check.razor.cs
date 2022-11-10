using AntDesign.Charts;
using Title = AntDesign.Charts.Title;
using Microsoft.AspNetCore.Components;
using Microsoft.Office.Interop.Excel;
using Syncfusion.Blazor.Inputs;
using System.Net.WebSockets;

namespace BlazorNhiber1.Pages
{
    public partial class Check : ComponentBase
    {
        List<object> data1 = new List<object>();
        IChartComponent myChart;
        protected override void OnAfterRender(bool firstRender)
        {
            base.OnAfterRender(firstRender);
        }
        protected override async Task OnInitializedAsync()
        {
            SinhVienSerivce service = new SinhVienSerivce();
            var sll1 = service.GetHocLucChart("Giỏi");
            int T1 = sll1.slToan;
            int V1 = sll1.slVan;
            int A1 = sll1.slAnh;
            data1.Add(
              new
              {
                  name = "Giỏi",
                  月份 = "Toán.",
                  月均降雨量 = T1,
              });
            data1.Add(
      new
      {
          name = "Giỏi",
          月份 = "Văn.",
          月均降雨量 = V1,
      });
            data1.Add(
            new
            {
                name = "Giỏi",
                月份 = "Anh.",
                月均降雨量 = A1,
            });

            var sll2 = service.GetHocLucChart("Khá");
            int T2 = sll2.slToan;
            int V2 = sll2.slVan;
            int A2 = sll2.slAnh;
            data1.Add(
            new

            {
                name = "Khá",
                月份 = "Toán.",
                月均降雨量 = T2,
            });
            data1.Add(
        new
        {
            name = "Khá",
            月份 = "Văn.",
            月均降雨量 = V2,
        });
            data1.Add(
        new
        {
            name = "Khá",
            月份 = "Anh.",
            月均降雨量 = A2,
        });

            var sll3 = service.GetHocLucChart("Giỏi");
            int T3 = sll3.slToan;
            int V3 = sll3.slVan;
            int A3 = sll3.slAnh;
            data1.Add(
            new
            {
                name = "Trung bình",
                月份 = "Toán.",
                月均降雨量 = T3,
            });
            data1.Add(
        new

        {
            name = "Trung bình",
            月份 = "Văn.",
            月均降雨量 = V3,
        });
            data1.Add(
        new
        {
            name = "Trung bình",
            月份 = "Anh.",
            月均降雨量 = A3,
        });

            var sll4 = service.GetHocLucChart("Trung Bình");
            int T4 = sll4.slToan;
            int V4 = sll4.slVan;
            int A4 = sll4.slAnh;
            data1.Add(
            new
            {
                name = "Yếu",
                月份 = "Toán.",
                月均降雨量 = T4,
            });
            data1.Add(
        new
        {
            name = "Yếu",
            月份 = "Văn.",
            月均降雨量 = V4,
        });
            data1.Add(
        new
        {
            name = "Yếu",
            月份 = "Anh.",
            月均降雨量 = A4,
        });
            await base.OnInitializedAsync();

        }


        ColumnConfig config1 = new ColumnConfig()
        {
            IsGroup = true,
            Title = new AntDesign.Charts.Title()
            {
                Visible = true,
                Text = "分组柱状图",
            },
            ForceFit = true,
            XField = "月份",
            YField = "月均降雨量",
            YAxis = new ValueAxis()
            {
                Min = 0,
            },
            Label = new ColumnViewConfigLabel()
            {
                Visible = true,
            },
            SeriesField = "name",
            Color = new string[] { "#00BFFF", "#00B2EE", "#009ACD", "#00688B" },
        };





    }
}

