// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GenerateDarkWaterMarkResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("darkWatermarkVOList")]
        [Validation(Required=false)]
        public List<GenerateDarkWaterMarkResponseBodyDarkWatermarkVOList> DarkWatermarkVOList { get; set; }
        public class GenerateDarkWaterMarkResponseBodyDarkWatermarkVOList : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://down-cdn.dingtalk.com/ddmedia/iAEKAqRmaWxlAwYEzh55BdsFzlFx040G2gAhhAGkC1HdIgKqLZPt3bUH2pAeUAPPAAABgRPQ5KgEzTBIBwAIAA.file">https://down-cdn.dingtalk.com/ddmedia/iAEKAqRmaWxlAwYEzh55BdsFzlFx040G2gAhhAGkC1HdIgKqLZPt3bUH2pAeUAPPAAABgRPQ5KgEzTBIBwAIAA.file</a></para>
            /// </summary>
            [NameInMap("darkWatermark")]
            [Validation(Required=false)]
            public string DarkWatermark { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0138350100401024915916</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
