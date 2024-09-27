// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class GetAdjustmentsResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetAdjustmentsResponseBodyResult Result { get; set; }
        public class GetAdjustmentsResponseBodyResult : TeaModel {
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<GetAdjustmentsResponseBodyResultItems> Items { get; set; }
            public class GetAdjustmentsResponseBodyResultItems : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("settingId")]
                [Validation(Required=false)]
                public long? SettingId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("totalPage")]
            [Validation(Required=false)]
            public long? TotalPage { get; set; }

        }

    }

}
