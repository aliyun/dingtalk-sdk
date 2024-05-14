// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkfinance_1_0.Models
{
    public class NotifyVerifyResultRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("payCode")]
        [Validation(Required=false)]
        public string PayCode { get; set; }

        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("userCorpRelationType")]
        [Validation(Required=false)]
        public string UserCorpRelationType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("userIdentity")]
        [Validation(Required=false)]
        public string UserIdentity { get; set; }

        [NameInMap("verifyEvent")]
        [Validation(Required=false)]
        public string VerifyEvent { get; set; }

        [NameInMap("verifyLocation")]
        [Validation(Required=false)]
        public string VerifyLocation { get; set; }

        [NameInMap("verifyNo")]
        [Validation(Required=false)]
        public string VerifyNo { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("verifyResult")]
        [Validation(Required=false)]
        public bool? VerifyResult { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("verifyTime")]
        [Validation(Required=false)]
        public string VerifyTime { get; set; }

    }

}
