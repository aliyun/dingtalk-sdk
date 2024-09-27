// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class UpdateRangeRequest : TeaModel {
        [NameInMap("backgroundColors")]
        [Validation(Required=false)]
        public List<List<string>> BackgroundColors { get; set; }

        [NameInMap("fontSizes")]
        [Validation(Required=false)]
        public List<List<int?>> FontSizes { get; set; }

        [NameInMap("fontWeights")]
        [Validation(Required=false)]
        public List<List<string>> FontWeights { get; set; }

        [NameInMap("horizontalAlignments")]
        [Validation(Required=false)]
        public List<List<string>> HorizontalAlignments { get; set; }

        [NameInMap("hyperlinks")]
        [Validation(Required=false)]
        public List<List<UpdateRangeRequestHyperlinks>> Hyperlinks { get; set; }
        public class UpdateRangeRequestHyperlinks : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>hyperlink_type</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>hyperlink_link</para>
            /// </summary>
            [NameInMap("link")]
            [Validation(Required=false)]
            public string Link { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>hyperlink_text</para>
            /// </summary>
            [NameInMap("text")]
            [Validation(Required=false)]
            public string Text { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>number_format</para>
        /// </summary>
        [NameInMap("numberFormat")]
        [Validation(Required=false)]
        public string NumberFormat { get; set; }

        [NameInMap("values")]
        [Validation(Required=false)]
        public List<List<string>> Values { get; set; }

        [NameInMap("verticalAlignments")]
        [Validation(Required=false)]
        public List<List<string>> VerticalAlignments { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>union_id</para>
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}
