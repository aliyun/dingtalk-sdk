// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class ListMiniAppHistoryVersionResponseBody : TeaModel {
        [NameInMap("list")]
        [Validation(Required=false)]
        public List<ListMiniAppHistoryVersionResponseBodyList> List { get; set; }
        public class ListMiniAppHistoryVersionResponseBodyList : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0-打包中 ，1-成功，2-失败</para>
            /// </summary>
            [NameInMap("buildStatus")]
            [Validation(Required=false)]
            public long? BuildStatus { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://xxx.con/download/id">https://xxx.con/download/id</a></para>
            /// </summary>
            [NameInMap("h5Bundle")]
            [Validation(Required=false)]
            public string H5Bundle { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5000</para>
            /// </summary>
            [NameInMap("packageSize")]
            [Validation(Required=false)]
            public string PackageSize { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://xxx.con/download/id">https://xxx.con/download/id</a></para>
            /// </summary>
            [NameInMap("packageUrl")]
            [Validation(Required=false)]
            public string PackageUrl { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0.5</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

    }

}
