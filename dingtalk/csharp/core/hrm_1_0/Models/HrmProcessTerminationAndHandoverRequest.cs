// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class HrmProcessTerminationAndHandoverRequest : TeaModel {
        [NameInMap("aflowHandOverUserId")]
        [Validation(Required=false)]
        public string AflowHandOverUserId { get; set; }

        [NameInMap("dingPanHandoverUserId")]
        [Validation(Required=false)]
        public string DingPanHandoverUserId { get; set; }

        [NameInMap("directSubordinatesHandoverUserId")]
        [Validation(Required=false)]
        public string DirectSubordinatesHandoverUserId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("dismissionMemo")]
        [Validation(Required=false)]
        public string DismissionMemo { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("dismissionReason")]
        [Validation(Required=false)]
        public int? DismissionReason { get; set; }

        [NameInMap("docNoteHandoverUserId")]
        [Validation(Required=false)]
        public string DocNoteHandoverUserId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("lastWorkDate")]
        [Validation(Required=false)]
        public long? LastWorkDate { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("optUserId")]
        [Validation(Required=false)]
        public string OptUserId { get; set; }

        [NameInMap("permissionHandoverUserId")]
        [Validation(Required=false)]
        public string PermissionHandoverUserId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
