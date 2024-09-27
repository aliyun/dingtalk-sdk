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
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("data")]
            [Validation(Required=false)]
            public Dictionary<string, object> Data { get; set; }

            [NameInMap("extendData")]
            [Validation(Required=false)]
            public Dictionary<string, object> ExtendData { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>manager123</para>
        /// </summary>
        [NameInMap("creatorUserId")]
        [Validation(Required=false)]
        public string CreatorUserId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public Dictionary<string, object> Data { get; set; }

        [NameInMap("extendData")]
        [Validation(Required=false)]
        public Dictionary<string, object> ExtendData { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxx-xxxx-xxxx-xxxx</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>crm_customer</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
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

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("saveOption")]
        [Validation(Required=false)]
        public CreateCustomerRequestSaveOption SaveOption { get; set; }
        public class CreateCustomerRequestSaveOption : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>APPEND_CONTACT_FORCE</para>
            /// </summary>
            [NameInMap("customerExistedPolicy")]
            [Validation(Required=false)]
            public string CustomerExistedPolicy { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("skipDuplicateCheck")]
            [Validation(Required=false)]
            public bool? SkipDuplicateCheck { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("subscribePolicy")]
            [Validation(Required=false)]
            public long? SubscribePolicy { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("throwExceptionWhileSavingContactFailed")]
            [Validation(Required=false)]
            public bool? ThrowExceptionWhileSavingContactFailed { get; set; }

        }

    }

}
