// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class InvalidSignRecordsRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("invalidUserId")]
        [Validation(Required=false)]
        public string InvalidUserId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("signRecordIds")]
        [Validation(Required=false)]
        public List<string> SignRecordIds { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("statusRemark")]
        [Validation(Required=false)]
        public string StatusRemark { get; set; }

    }

}
