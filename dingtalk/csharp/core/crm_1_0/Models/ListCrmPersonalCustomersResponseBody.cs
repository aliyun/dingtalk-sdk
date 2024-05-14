// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class ListCrmPersonalCustomersResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListCrmPersonalCustomersResponseBodyResult> Result { get; set; }
        public class ListCrmPersonalCustomersResponseBodyResult : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("appUuid")]
            [Validation(Required=false)]
            public string AppUuid { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("creatorNick")]
            [Validation(Required=false)]
            public string CreatorNick { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("creatorUserId")]
            [Validation(Required=false)]
            public string CreatorUserId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("data")]
            [Validation(Required=false)]
            public Dictionary<string, object> Data { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("extendData")]
            [Validation(Required=false)]
            public Dictionary<string, object> ExtendData { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("formCode")]
            [Validation(Required=false)]
            public string FormCode { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("objectType")]
            [Validation(Required=false)]
            public string ObjectType { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("permission")]
            [Validation(Required=false)]
            public ListCrmPersonalCustomersResponseBodyResultPermission Permission { get; set; }
            public class ListCrmPersonalCustomersResponseBodyResultPermission : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("ownerStaffIds")]
                [Validation(Required=false)]
                public List<string> OwnerStaffIds { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("participantStaffIds")]
                [Validation(Required=false)]
                public List<string> ParticipantStaffIds { get; set; }

            }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("procInstStatus")]
            [Validation(Required=false)]
            public string ProcInstStatus { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("procOutResult")]
            [Validation(Required=false)]
            public string ProcOutResult { get; set; }

        }

    }

}
