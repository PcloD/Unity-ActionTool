﻿//
// GPActionSwitchVar.cs
//
// Author(s):
//       Baptiste Dupy <baptiste.dupy@gmail.com>
//
// Copyright (c) 2014
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.


using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace ActionTool
{
	[GPActionAlias("Variable/Bool/Switch")]
	public class GPActionSwitchVar : GPActionVariable 
	{
		#region Public Members
		
		public bool _trigger;
		
		#endregion
		
		#region GPAction Override
		
		protected override void OnTrigger()
		{
			_trigger = !_trigger;

			End();
		}

#if UNITY_EDITOR
		
		public override void DrawWindowContent()
		{
			base.DrawWindowContent();
			GUILayout.Label(_trigger.ToString());
		}
		
#endif

		#endregion
		
		#region GPActionVariable Override
		
		public override object GetValue ()
		{
			return _trigger;
		}

        public override void SetValue(System.Object value)
        {
            _trigger = (bool)value;
        }
		
		#endregion
	}
}