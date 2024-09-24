// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class RevokeSignRecordsResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public RevokeSignRecordsResponseBodyResult Result { get; set; }
        public class RevokeSignRecordsResponseBodyResult : TeaModel {
            [NameInMap("failItems")]
            [Validation(Required=false)]
            public List<RevokeSignRecordsResponseBodyResultFailItems> FailItems { get; set; }
            public class RevokeSignRecordsResponseBodyResultFailItems : TeaModel {
                [NameInMap("itemId")]
                [Validation(Required=false)]
                public string ItemId { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("successItems")]
            [Validation(Required=false)]
            public List<RevokeSignRecordsResponseBodyResultSuccessItems> SuccessItems { get; set; }
            public class RevokeSignRecordsResponseBodyResultSuccessItems : TeaModel {
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
