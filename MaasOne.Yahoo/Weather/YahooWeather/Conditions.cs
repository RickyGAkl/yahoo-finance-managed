﻿// ******************************************************************************
// ** 
// **  Yahoo! Managed
// **  Originally written by Marius Häusler 2012
// **  Now it is maintained by the public community on GitHub
// **  Any contributions will be greatly appreciated.  Please go to be project home below and create a fork, make your change and merge back.
// **  Project Home: https://github.com/RickyGAkl/yahoo-finance-managed
// **  
// ******************************************************************************
// **  
// **  Copyright 2012 Marius Häusler
// **  
// **  Licensed under the Apache License, Version 2.0 (the "License");
// **  you may not use this file except in compliance with the License.
// **  You may obtain a copy of the License at
// **  
// **    http://www.apache.org/licenses/LICENSE-2.0
// **  
// **  Unless required by applicable law or agreed to in writing, software
// **  distributed under the License is distributed on an "AS IS" BASIS,
// **  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// **  See the License for the specific language governing permissions and
// **  limitations under the License.
// ** 
// ******************************************************************************

using System;

namespace YahooManaged.Services.Weather.YahooWeather
{

	public class Condition
	{
		public string Description { get; set; }
		public ConditionType Type { get; set; }
		public DateTime ForecastDate { get; set; }
		public Uri ImageNightUri {
			get { return this.ConditionImageUri(true); }
		}
		public Uri ImageDayUri {
			get { return this.ConditionImageUri(false); }
		}

		public Uri GetAutoImage(AstronomyInfo astro)
		{
			DateTime fcTime = new DateTime().AddHours(this.ForecastDate.Hour).AddMinutes(this.ForecastDate.Minute);
			if (DateTime.UtcNow.Hour == fcTime.Hour & System.DateTime.UtcNow.Minute == fcTime.Minute) {
				return this.ImageDayUri;
			} else if (fcTime > astro.Sunrise & fcTime < astro.Sunset) {
				return this.ImageDayUri;
			} else {
				return this.ImageNightUri;
			}
		}

		private Uri ConditionImageUri(bool isNight)
		{
			if (this.Type != ConditionType.Not_Available) {
				string dayNightTag = "d";
				if (isNight)
					dayNightTag = "n";
				return new Uri("http://l.yimg.com/a/i/us/nws/weather/gr/" + Convert.ToInt32(this.Type).ToString() + dayNightTag + ".png");
			} else {
				return null;
			}
		}
	}

	public class ActualCondition : Condition
	{
		public int Temperature { get; set; }
		public string TimeZoneId { get; set; }
	}

	public class Forecast : Condition
	{
		public DayOfWeek Day { get; set; }
		public int HighTemperature { get; set; }
		public int LowTemperature { get; set; }
	}

}
