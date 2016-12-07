﻿#region COPYRIGHT
//
//     THIS IS GENERATED BY TEMPLATE
//     
//     AUTHOR  :     ROYE
//     DATE       :     2010
//
//     COPYRIGHT (C) 2010, TIANXIAHOTEL TECHNOLOGIES CO., LTD. ALL RIGHTS RESERVED.
//
#endregion

using System;
using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TX.Framework.WindowUI.Controls
{
    public class TemplateColumnHeader : ColumnHeader, IComparer
    {
        private string _ColumnTemplate;
        private IContainer components;
        private bool _CanEdit;

        public TemplateColumnHeader()
            : base()
        {
            //this.TextAlign = HorizontalAlignment.Center;
            _CanEdit = false;
        }

        [
        Description("是否允许修改"),
        DefaultValue(false)
        ]
        public bool CanEdit { get; set; }

        [
        Description("ColumnTemplate"),
        Localizable(true)
        ]
        public string Template { get; set; }

        [
        Description("数据类型"), 
        Localizable(true),
        DefaultValue(HeaderDataType.String)
        ]
        public HeaderDataType DataType { get; set; }

        [Browsable(false)]
        public int Column { get; set; }

        public int Compare(object x, object y)
        {
            object left = ((ListViewItem)x).SubItems[this.Column];
            object right = ((ListViewItem)y).SubItems[this.Column];

            ListViewSorter sorter = null;
            switch (DataType)
            {
                case HeaderDataType.String:
                    sorter = new ListViewStringSorter();
                    break;
                case HeaderDataType.Int32:
                    sorter = new ListViewInt32Sorter();
                    break;
                case HeaderDataType.Date:
                    sorter = new ListViewDateSorter();
                    break;
                default:
                    sorter = new ListViewStringSorter();
                    break;
            }
            if (this.ListView == null)
            {
                return 0;
            }
            return sorter.OnSort(left, right, this.ListView.Sorting);
        }
    }

    public enum HeaderDataType
    {
        String,
        Int32,
        Date
    }
}
