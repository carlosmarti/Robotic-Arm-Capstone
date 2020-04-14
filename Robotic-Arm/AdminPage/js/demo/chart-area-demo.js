// Set new default font family and font color to mimic Bootstrap's default styling
Chart.defaults.global.defaultFontFamily = 'Nunito', '-apple-system,system-ui,BlinkMacSystemFont,"Segoe UI",Roboto,"Helvetica Neue",Arial,sans-serif';
Chart.defaults.global.defaultFontColor = '#858796';

function number_format(number, decimals, dec_point, thousands_sep) {
  // *     example: number_format(1234.56, 2, ',', ' ');
  // *     return: '1 234,56'
  number = (number + '').replace(',', '').replace(' ', '');
  var n = !isFinite(+number) ? 0 : +number,
    prec = !isFinite(+decimals) ? 0 : Math.abs(decimals),
    sep = (typeof thousands_sep === 'undefined') ? ',' : thousands_sep,
    dec = (typeof dec_point === 'undefined') ? '.' : dec_point,
    s = '',
    toFixedFix = function(n, prec) {
      var k = Math.pow(10, prec);
      return '' + Math.round(n * k) / k;
    };
  // Fix for IE parseFloat(0.55).toFixed(0) = 0;
  s = (prec ? toFixedFix(n, prec) : '' + Math.round(n)).split('.');
  if (s[0].length > 3) {
    s[0] = s[0].replace(/\B(?=(?:\d{3})+(?!\d))/g, sep);
  }
  if ((s[1] || '').length < prec) {
    s[1] = s[1] || '';
    s[1] += new Array(prec - s[1].length + 1).join('0');
  }
  return s.join(dec);
}

//connect to database
function showData(str)
{

  if(str != "")
  {
    var xmlhttp = new XMLHttpRequest();
    var timeData = new Array();
    console.log("opening php file to get data on: " + str);
    xmlhttp.open("GET", "../../php/getData.php?a="+str, false);

    //check if connection happend
    xmlhttp.onreadystatechange = function()
    {
		
      if((this.status >= 200 && this.status <= 400))
      {
        var obj = JSON.parse(xmlhttp.responseText);

        console.log("received data: Test:" + obj['testNo']);
        console.log("received data: CycleNo:" + obj['cycleNo']);
        console.log("received data: Time:" + obj['time']);
		
        timeData[0] = obj['testNo'].toString();
        timeData[1] = obj['cycleNo'].toString();
        timeData[2] = obj['time'].toString();
        var timeData0 = timeData[0].split(",");
        var timeData1 = timeData[1].split(",");
        var timeData2 = timeData[2].split(",");
        timeData = timeData0.concat(timeData1, timeData2);
		//removes any empty elements when grabbing selective data
		timeData = timeData.filter(function(obj) {return obj});
		
        console.log(timeData);

      }
	  else{
		  console.log("Not connected!!")
	  }
      
    }

    xmlhttp.send();

    //add code here to show data on chart

    return timeData;
    


    return timeData;

  }
  
}

// Area Chart Example
var ctx = document.getElementById("myAreaChart");

console.log(showData("0"));
var lineData = showData("3");
console.log(lineData);

//determining number of lines to draw by dividing the time data by 6 - or by the number of cycles per test

var numLines = lineData.length / 6;
lineChartData = {};
lineChartData.labels = ["Cycle 1", "Cycle 2", "Cycle 3", "Cycle 4", "Cycle 5", "Cycle 6"];
lineChartData.datasets = [];
lineChartData.datasets.label = "Times"

for (i = 0; i < numLines; i++){
	
	y = [];
	lineChartData.datasets.push({});
	dataset = lineChartData.datasets[i];
	dataset.fillColor = "rgba(0, 0, 0, 0)";
	dataset.strokeColor = "rgba(102, 92, 35, 1)";
	dataset.data = lineData.slice(0 + (6 * i), 5 + (6 * i));
	
	for (j = 0; j < 6; j++){
		y.push(dataset.data[j]);
		
		
	}
	
	lineChartData.datasets[i].data = y;
}



var myLineChart = new Chart(ctx, {
  type: 'line',
  data:lineChartData,
  
  options: {
    maintainAspectRatio: false,
    layout: {
      padding: {
        left: 10,
        right: 25,
        top: 25,
        bottom: 0
      }
    },
    scales: {
      xAxes: [{
        time: {
          unit: 'Seconds'
        },
        gridLines: {
          display: false,
          drawBorder: false
        },
        ticks: {
          maxTicksLimit: 10
        }
      }],
      yAxes: [{
        ticks: {
		  beginAtZero: true,
          maxTicksLimit: 10,
          padding: 10,
          callback: function(value, index, values) {
            return number_format(value);
          }
        },
        gridLines: {
          color: "rgb(234, 236, 244)",
          zeroLineColor: "rgb(234, 236, 244)",
          drawBorder: false,
          borderDash: [2],
          zeroLineBorderDash: [2]
        }
      }],
    },
    legend: {
      display: false
    },
    tooltips: {
      backgroundColor: "rgb(255,255,255)",
      bodyFontColor: "#858796",
      titleMarginBottom: 10,
      titleFontColor: '#6e707e',
      titleFontSize: 14,
      borderColor: '#dddfeb',
      borderWidth: 1,
      xPadding: 15,
      yPadding: 15,
      displayColors: false,
      intersect: false,
      mode: 'index',
      caretPadding: 10,
      callbacks: {
        label: function(tooltipItem, chart) {
          var datasetLabel = chart.datasets[tooltipItem.datasetIndex].label || '';
          return datasetLabel + number_format(tooltipItem.yLabel);
        }
      }
    }
  }
});
