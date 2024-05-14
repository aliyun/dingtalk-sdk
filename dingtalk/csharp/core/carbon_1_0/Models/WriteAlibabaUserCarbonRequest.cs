// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcarbon_1_0.Models
{
    public class WriteAlibabaUserCarbonRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("userDetailsList")]
        [Validation(Required=false)]
        public List<WriteAlibabaUserCarbonRequestUserDetailsList> UserDetailsList { get; set; }
        public class WriteAlibabaUserCarbonRequestUserDetailsList : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("actionEndTime")]
            [Validation(Required=false)]
            public string ActionEndTime { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("actionId")]
            [Validation(Required=false)]
            public string ActionId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("actionStartTime")]
            [Validation(Required=false)]
            public string ActionStartTime { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("actionType")]
            [Validation(Required=false)]
            public string ActionType { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("carbonAmount")]
            [Validation(Required=false)]
            public string CarbonAmount { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("deptId")]
            [Validation(Required=false)]
            public long? DeptId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public int? Version { get; set; }

        }

    }

}
