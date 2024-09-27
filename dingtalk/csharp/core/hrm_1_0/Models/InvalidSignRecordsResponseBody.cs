// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class InvalidSignRecordsResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public InvalidSignRecordsResponseBodyResult Result { get; set; }
        public class InvalidSignRecordsResponseBodyResult : TeaModel {
            [NameInMap("failItems")]
            [Validation(Required=false)]
            public List<InvalidSignRecordsResponseBodyResultFailItems> FailItems { get; set; }
            public class InvalidSignRecordsResponseBodyResultFailItems : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1234566789</para>
                /// </summary>
                [NameInMap("itemId")]
                [Validation(Required=false)]
                public string ItemId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>电子签状态变更不合法</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("successItems")]
            [Validation(Required=false)]
            public List<InvalidSignRecordsResponseBodyResultSuccessItems> SuccessItems { get; set; }
            public class InvalidSignRecordsResponseBodyResultSuccessItems : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>123456789</para>
                /// </summary>
                [NameInMap("itemId")]
                [Validation(Required=false)]
                public string ItemId { get; set; }

            }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
