// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class UpdateRangeRequest : TeaModel {
        /// <summary>
        /// 背景色
        /// </summary>
        [NameInMap("backgroundColors")]
        [Validation(Required=false)]
        public List<List<string>> BackgroundColors { get; set; }

        /// <summary>
        /// 超链接
        /// </summary>
        [NameInMap("hyperlinks")]
        [Validation(Required=false)]
        public List<List<UpdateRangeRequestHyperlinks>> Hyperlinks { get; set; }
        public class UpdateRangeRequestHyperlinks : TeaModel {
            /// <summary>
            /// 超链接类型，可选 "path", "sheet", "range"
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// 链接地址
            /// </summary>
            [NameInMap("link")]
            [Validation(Required=false)]
            public string Link { get; set; }

            /// <summary>
            /// 链接文本
            /// </summary>
            [NameInMap("text")]
            [Validation(Required=false)]
            public string Text { get; set; }

        }

        /// <summary>
        /// 数字格式
        /// </summary>
        [NameInMap("numberFormat")]
        [Validation(Required=false)]
        public string NumberFormat { get; set; }

        /// <summary>
        /// 值
        /// </summary>
        [NameInMap("values")]
        [Validation(Required=false)]
        public List<List<string>> Values { get; set; }

        /// <summary>
        /// 操作人unionId
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}
