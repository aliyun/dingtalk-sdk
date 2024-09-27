// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class QueryDeviceListByCorpIdResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryDeviceListByCorpIdResponseBodyResult Result { get; set; }
        public class QueryDeviceListByCorpIdResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("list")]
            [Validation(Required=false)]
            public List<QueryDeviceListByCorpIdResponseBodyResultList> List { get; set; }
            public class QueryDeviceListByCorpIdResponseBodyResultList : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("appStatus")]
                [Validation(Required=false)]
                public int? AppStatus { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("deviceCode")]
                [Validation(Required=false)]
                public string DeviceCode { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("deviceName")]
                [Validation(Required=false)]
                public string DeviceName { get; set; }

            }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
