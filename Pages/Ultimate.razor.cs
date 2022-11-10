using AntDesign.Charts;
using Title = AntDesign.Charts.Title;
using Microsoft.AspNetCore.Components;
using Microsoft.Office.Interop.Excel;
using Syncfusion.Blazor.Inputs;
using System.Net.WebSockets;

namespace BlazorNhiber1.Pages
{
    public partial class Ultimate : ComponentBase
    {
        List<object> data1 = new List<object>();
        IChartComponent myChart;
        //protected override void OnAfterRender(bool firstRender)
        //{
        //    base.OnAfterRender(firstRender);
        //}
           protected override async Task OnInitializedAsync()
        {
                SinhVienSerivce service = new SinhVienSerivce();
                //var sll1 = service.GetHocLucChart("Giỏi");
                var abc = await service.JoinTest();
            int T1 = abc.CountToanGioi;
            int V1 = abc.CountVanGioi;
            int A1 = abc.CountAnhGioi;
           

            data1.Add(
                  new
                  {
                      name = "Giỏi",
                      月份 = "Toán.",
                      月均降雨量 = A1,
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
          
            //var sll2 = service.GetHocLucChart("Khá");
            int T2 = abc.CountToanKha;
            int V2 = abc.CountVanKha;
            int A2 = abc.CountAnhKha;
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
          
            //var sll3 = service.GetHocLucChart("Giỏi");
            int T3 = abc.CountToanTrungBinh;
            int V3 = abc.CountVanTrungBinh;
            int A3 = abc.CountAnhTrungBinh;
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
           
            //var sll4 = service.GetHocLucChart("Trung Bình");
            int T4 = abc.CountAll-abc.CountToanGioi-abc.CountToanKha-abc.CountToanTrungBinh;
            int V4 = abc.CountAll - abc.CountAnhGioi - abc.CountVanKha - abc.CountVanTrungBinh;
            int A4 = abc.CountAll - abc.CountAnhGioi - abc.CountAnhKha - abc.CountAnhTrungBinh;
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

