// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class CreateCustomerRequest : TeaModel {
        [NameInMap("contacts")]
        [Validation(Required=false)]
        public List<CreateCustomerRequestContacts> Contacts { get; set; }
        public class CreateCustomerRequestContacts : TeaModel {
            [NameInMap("data")]
            [Validation(Required=false)]
            public Dictionary<string, object> Data { get; set; }

            [NameInMap("extendData")]
            [Validation(Required=false)]
            public Dictionary<string, object> ExtendData { get; set; }

        }

        [NameInMap("creatorUserId")]
        [Validation(Required=false)]
        public string CreatorUserId { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public Dictionary<string, object> Data { get; set; }

        [NameInMap("extendData")]
        [Validation(Required=false)]
        public Dictionary<string, object> ExtendData { get; set; }

        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("objectType")]
        [Validation(Required=false)]
        public string ObjectType { get; set; }

        [NameInMap("permission")]
        [Validation(Required=false)]
        public CreateCustomerRequestPermission Permission { get; set; }
        public class CreateCustomerRequestPermission : TeaModel {
            [NameInMap("ownerStaffIds")]
            [Validation(Required=false)]
            public List<string> OwnerStaffIds { get; set; }

            [NameInMap("participantStaffIds")]
            [Validation(Required=false)]
            public List<string> ParticipantStaffIds { get; set; }

        }

        [NameInMap("saveOption")]
        [Validation(Required=false)]
        public CreateCustomerRequestSaveOption SaveOption { get; set; }
        public class CreateCustomerRequestSaveOption : TeaModel {
            [NameInMap("customerExistedPolicy")]
            [Validation(Required=false)]
            public string CustomerExistedPolicy { get; set; }

            [NameInMap("skipDuplicateCheck")]
            [Validation(Required=false)]
            public bool? SkipDuplicateCheck { get; set; }

            [NameInMap("subscribePolicy")]
            [Validation(Required=false)]
            public long? SubscribePolicy { get; set; }

            [NameInMap("throwExceptionWhileSavingContactFailed")]
            [Validation(Required=false)]
            public bool? ThrowExceptionWhileSavingContactFailed { get; set; }

        }

    }

}
