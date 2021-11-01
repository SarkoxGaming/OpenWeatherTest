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

            Assert.ThrowsAsync<ArgumentException>(owp.GetOneCallAsync);

        }


    }
}
