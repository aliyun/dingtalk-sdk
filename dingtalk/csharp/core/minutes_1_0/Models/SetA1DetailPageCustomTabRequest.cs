// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkminutes_1_0.Models
{
    public class SetA1DetailPageCustomTabRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("customTabList")]
        [Validation(Required=false)]
        public List<SetA1DetailPageCustomTabRequestCustomTabList> CustomTabList { get; set; }
        public class SetA1DetailPageCustomTabRequestCustomTabList : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>analyze</para>
            /// </summary>
            [NameInMap("bizType")]
            [Validation(Required=false)]
            public string BizType { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn_ZH</para>
            /// </summary>
            [NameInMap("defaultLocale")]
            [Validation(Required=false)]
            public string DefaultLocale { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("nameI18nMap")]
            [Validation(Required=false)]
            public Dictionary<string, object> NameI18nMap { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://example.com/pc/tab">https://example.com/pc/tab</a></para>
            /// </summary>
            [NameInMap("pcUrl")]
            [Validation(Required=false)]
            public string PcUrl { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/tab">https://example.com/tab</a></para>
            /// </summary>
            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>true时保留已有A1分析Tab并替换其它自定义Tab；false或不传时直接使用本次列表覆盖</para>
        /// </summary>
        [NameInMap("preserveA1AnalyzeTab")]
        [Validation(Required=false)]
        public bool? PreserveA1AnalyzeTab { get; set; }

    }

}
