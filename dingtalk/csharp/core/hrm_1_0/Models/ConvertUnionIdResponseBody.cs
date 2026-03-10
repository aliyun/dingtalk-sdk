// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class ConvertUnionIdResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public ConvertUnionIdResponseBodyResult Result { get; set; }
        public class ConvertUnionIdResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>corpId123</para>
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("isvUserUnionIdVOList")]
            [Validation(Required=false)]
            public List<ConvertUnionIdResponseBodyResultIsvUserUnionIdVOList> IsvUserUnionIdVOList { get; set; }
            public class ConvertUnionIdResponseBodyResultIsvUserUnionIdVOList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>unionId123</para>
                /// </summary>
                [NameInMap("unionId")]
                [Validation(Required=false)]
                public string UnionId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>userId123</para>
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
