// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class UpdateCrmPersonalCustomerRequest : TeaModel {
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("modifierUserId")]
        [Validation(Required=false)]
        public string ModifierUserId { get; set; }

        [NameInMap("modifierNick")]
        [Validation(Required=false)]
        public string ModifierNick { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public Dictionary<string, object> Data { get; set; }

        [NameInMap("extendData")]
        [Validation(Required=false)]
        public Dictionary<string, object> ExtendData { get; set; }

        [NameInMap("permission")]
        [Validation(Required=false)]
        public UpdateCrmPersonalCustomerRequestPermission Permission { get; set; }
        public class UpdateCrmPersonalCustomerRequestPermission : TeaModel {
            [NameInMap("ownerStaffIds")]
            [Validation(Required=false)]
            public List<string> OwnerStaffIds { get; set; }
            [NameInMap("participantStaffIds")]
            [Validation(Required=false)]
            public List<string> ParticipantStaffIds { get; set; }
        };

    }

}
