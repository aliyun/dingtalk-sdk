// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkminutes_1_0.Models
{
    public class SetDetailPageCustomTabRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("customTabList")]
        [Validation(Required=false)]
        public List<SetDetailPageCustomTabRequestCustomTabList> CustomTabList { get; set; }
        public class SetDetailPageCustomTabRequestCustomTabList : TeaModel {
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lJcRnm39OsU4jlFVmRGXXXXX</para>
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
