// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrbrain_1_0.Models
{
    public class HrbrainImportTransferEvalRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<HrbrainImportTransferEvalRequestBody> Body { get; set; }
        public class HrbrainImportTransferEvalRequestBody : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("currInfo")]
            [Validation(Required=false)]
            public Dictionary<string, object> CurrInfo { get; set; }

            [NameInMap("extendInfo")]
            [Validation(Required=false)]
            public Dictionary<string, object> ExtendInfo { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("preInfo")]
            [Validation(Required=false)]
            public Dictionary<string, object> PreInfo { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("transferDate")]
            [Validation(Required=false)]
            public string TransferDate { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("transferReason")]
            [Validation(Required=false)]
            public string TransferReason { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("transferType")]
            [Validation(Required=false)]
            public string TransferType { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("workNo")]
            [Validation(Required=false)]
            public string WorkNo { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

    }

}
