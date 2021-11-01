﻿using OpenWeatherAPI;
using System;
using Xunit;

namespace OpenWeatherAPITests
{
    public class OpenWeatherProcessorTests
    {

        [Fact]
        public void GetOneCallAsync_IfApiKeyEmptyOrNull_ThrowArgumentException()
        {
            OpenWeatherProcessor owp = OpenWeatherProcessor.Instance;
            ApiHelper.InitializeClient();

            Assert.ThrowsAsync<ArgumentException>(owp.GetOneCallAsync);
        }

        [Fact]
        public void GetCurrentWeatherAsync_IfApiKeyEmptyOrNull_ThrowArgumentException()
        {
            OpenWeatherProcessor owp = OpenWeatherProcessor.Instance;
            ApiHelper.InitializeClient();

            Assert.ThrowsAsync<ArgumentException>(owp.GetCurrentWeatherAsync);
        }

        [Fact]
        public void GetOneCallAsync_IfApiHelperNotInitialized_ThrowArgumentException()
        {
            OpenWeatherProcessor owp = OpenWeatherProcessor.Instance;
            
            Assert.ThrowsAsync<ArgumentException>(owp.GetOneCallAsync);
        }

        [Fact]
        public void GetCurrentWeatherAsync_IfApiHelperNotInitialized_ThrowArgumentException()
        {
            OpenWeatherProcessor owp = OpenWeatherProcessor.Instance;

            Assert.ThrowsAsync<ArgumentException>(owp.GetCurrentWeatherAsync);
        }

    }
}
