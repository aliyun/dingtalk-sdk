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
                [NameInMap("itemId")]
                [Validation(Required=false)]
                public string ItemId { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("successItems")]
            [Validation(Required=false)]
            public List<InvalidSignRecordsResponseBodyResultSuccessItems> SuccessItems { get; set; }
            public class InvalidSignRecordsResponseBodyResultSuccessItems : TeaModel {
                [NameInMap("itemId")]
                [Validation(Required=false)]
                public string ItemId { get; set; }

            }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
