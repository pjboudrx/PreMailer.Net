﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace PreMailer.Parsing
{
	public class RuleSetParser : IRuleSetParser
	{
		public RuleSet ParseRuleSet(string selectors, string style)
		{
			if (style == null)
			{
				throw new ArgumentNullException("style");
			}

			if (StringExtensions.IsNullOrWhiteSpace(style))
			{
				throw new ArgumentException("The style parameter is empty!", "style");
			}

			return null;
		}
	}
}