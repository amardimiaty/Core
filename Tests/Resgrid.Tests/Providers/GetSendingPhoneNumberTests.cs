﻿using FluentAssertions;
using NUnit.Framework;
using Resgrid.Providers.NumberProvider;

namespace Resgrid.Tests.Providers
{
	namespace GetSendingPhoneNumberTests
	{
		public class with_the_text_message_provider : TestBase
		{
			protected TextMessageProvider _textMessageProvider;

			protected with_the_text_message_provider()
			{
				_textMessageProvider = new TextMessageProvider();
			}
		}

		[TestFixture]
		public class when_trying_to_get_sending_number : with_the_text_message_provider
		{
			[Test]
			public void should_be_valid_for_empty()
			{
				var result = _textMessageProvider.GetSendingPhoneNumber("");
				result.Should().NotBeNullOrEmpty();
				//result.Should().Be(Resgrid.Config.NumberProviderConfig.SignalWireResgridNumber);
			}

			[Test]
			public void should_be_valid_for_null()
			{
				var result = _textMessageProvider.GetSendingPhoneNumber(null);
				result.Should().NotBeNullOrEmpty();
				//result.Should().Be(Resgrid.Config.NumberProviderConfig.SignalWireResgridNumber);
			}

			[Test]
			public void should_be_valid_for_cali()
			{
				var result = _textMessageProvider.GetSendingPhoneNumber("2135556987");
				result.Should().NotBeNullOrEmpty();
				result.Should().BeOneOf(Resgrid.Config.NumberProviderConfig.SignalWireZones[1]);
			}

			[Test]
			public void should_be_valid_for_montana()
			{
				var result = _textMessageProvider.GetSendingPhoneNumber("4065556987");
				result.Should().NotBeNullOrEmpty();
				result.Should().BeOneOf(Resgrid.Config.NumberProviderConfig.SignalWireZones[2]);
			}

			[Test]
			public void should_be_valid_for_illnois()
			{
				var result = _textMessageProvider.GetSendingPhoneNumber("8475556987");
				result.Should().NotBeNullOrEmpty();
				result.Should().BeOneOf(Resgrid.Config.NumberProviderConfig.SignalWireZones[3]);
			}

			[Test]
			public void should_be_valid_for_texas()
			{
				var result = _textMessageProvider.GetSendingPhoneNumber("5125556987");
				result.Should().NotBeNullOrEmpty();
				result.Should().BeOneOf(Resgrid.Config.NumberProviderConfig.SignalWireZones[4]);
			}


			[Test]
			public void should_be_valid_for_maryland()
			{
				var result = _textMessageProvider.GetSendingPhoneNumber("4105556987");
				result.Should().NotBeNullOrEmpty();
				result.Should().BeOneOf(Resgrid.Config.NumberProviderConfig.SignalWireZones[5]);
			}

			[Test]
			public void should_be_valid_for_virginia()
			{
				var result = _textMessageProvider.GetSendingPhoneNumber("7575556987");
				result.Should().NotBeNullOrEmpty();
				result.Should().BeOneOf(Resgrid.Config.NumberProviderConfig.SignalWireZones[6]);
			}
		}
	}
}
