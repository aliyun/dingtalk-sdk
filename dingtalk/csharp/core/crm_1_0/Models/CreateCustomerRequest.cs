// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class CreateCustomerRequest : TeaModel {
        /// <summary>
        /// 关联联系人数据
        /// </summary>
        [NameInMap("contacts")]
        [Validation(Required=false)]
        public List<CreateCustomerRequestContacts> Contacts { get; set; }
        public class CreateCustomerRequestContacts : TeaModel {
            /// <summary>
            /// 联系人表单数据
            /// </summary>
            [NameInMap("data")]
            [Validation(Required=false)]
            public Dictionary<string, object> Data { get; set; }

            /// <summary>
            /// 联系人扩展数据
            /// </summary>
            [NameInMap("extendData")]
            [Validation(Required=false)]
            public Dictionary<string, object> ExtendData { get; set; }

        }

        /// <summary>
        /// 创建人的userId
        /// </summary>
        [NameInMap("creatorUserId")]
        [Validation(Required=false)]
        public string CreatorUserId { get; set; }

        /// <summary>
        /// 客户实例数据（表单数据）
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public Dictionary<string, object> Data { get; set; }

        /// <summary>
        /// 客户实例扩展数据
        /// </summary>
        [NameInMap("extendData")]
        [Validation(Required=false)]
        public Dictionary<string, object> ExtendData { get; set; }

        /// <summary>
        /// 已存在客户时，添加联系人，可以传入客户的instanceId用作关联绑定
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 写入客户类型：个人客户crm_customer_personal; 企业客户crm_customer
        /// </summary>
        [NameInMap("objectType")]
        [Validation(Required=false)]
        public string ObjectType { get; set; }

        /// <summary>
        /// 权限
        /// </summary>
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
        };

        /// <summary>
        /// 保存配置项
        /// </summary>
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
        };

    }

}
