// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class ListCrmPersonalCustomersResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListCrmPersonalCustomersResponseBodyResult> Result { get; set; }
        public class ListCrmPersonalCustomersResponseBodyResult : TeaModel {
            [NameInMap("orgId")]
            [Validation(Required=false)]
            public long? OrgId { get; set; }

            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("objectType")]
            [Validation(Required=false)]
            public string ObjectType { get; set; }

            [NameInMap("creatorUserId")]
            [Validation(Required=false)]
            public string CreatorUserId { get; set; }

            [NameInMap("creatorNick")]
            [Validation(Required=false)]
            public string CreatorNick { get; set; }

            [NameInMap("data")]
            [Validation(Required=false)]
            public Dictionary<string, object> Data { get; set; }

            [NameInMap("extendData")]
            [Validation(Required=false)]
            public Dictionary<string, object> ExtendData { get; set; }

            [NameInMap("permission")]
            [Validation(Required=false)]
            public ListCrmPersonalCustomersResponseBodyResultPermission Permission { get; set; }
            public class ListCrmPersonalCustomersResponseBodyResultPermission : TeaModel {
                [NameInMap("ownerStaffIds")]
                [Validation(Required=false)]
                public List<string> OwnerStaffIds { get; set; }
                [NameInMap("participantStaffIds")]
                [Validation(Required=false)]
                public List<string> ParticipantStaffIds { get; set; }
            };

            [NameInMap("appUuid")]
            [Validation(Required=false)]
            public string AppUuid { get; set; }

            [NameInMap("formCode")]
            [Validation(Required=false)]
            public string FormCode { get; set; }

            [NameInMap("procOutResult")]
            [Validation(Required=false)]
            public string ProcOutResult { get; set; }

            [NameInMap("procInstStatus")]
            [Validation(Required=false)]
            public string ProcInstStatus { get; set; }

            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

        }

    }

}
