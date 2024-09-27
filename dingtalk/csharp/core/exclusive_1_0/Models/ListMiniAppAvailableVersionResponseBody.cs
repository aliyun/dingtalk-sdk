// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class ListMiniAppAvailableVersionResponseBody : TeaModel {
        [NameInMap("list")]
        [Validation(Required=false)]
        public List<ListMiniAppAvailableVersionResponseBodyList> List { get; set; }
        public class ListMiniAppAvailableVersionResponseBodyList : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("buildStatus")]
            [Validation(Required=false)]
            public long? BuildStatus { get; set; }

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
