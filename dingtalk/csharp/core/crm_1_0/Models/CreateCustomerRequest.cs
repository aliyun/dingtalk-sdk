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
            /// <summary>
            /// 负责人
            /// </summary>
            [NameInMap("ownerStaffIds")]
            [Validation(Required=false)]
            public List<string> OwnerStaffIds { get; set; }

            /// <summary>
            /// 协同人
            /// </summary>
            [NameInMap("participantStaffIds")]
            [Validation(Required=false)]
            public List<string> ParticipantStaffIds { get; set; }

        }

        /// <summary>
        /// 保存配置项
        /// </summary>
        [NameInMap("saveOption")]
        [Validation(Required=false)]
        public CreateCustomerRequestSaveOption SaveOption { get; set; }
        public class CreateCustomerRequestSaveOption : TeaModel {
            /// <summary>
            /// 客户已存在时的处理策略：APPEND_CONTACT_FORCE 直接追加联系人； REJECT 返回失败
            /// </summary>
            [NameInMap("customerExistedPolicy")]
            [Validation(Required=false)]
            public string CustomerExistedPolicy { get; set; }

            /// <summary>
            /// 跳过uk查重
            /// </summary>
            [NameInMap("skipDuplicateCheck")]
            [Validation(Required=false)]
            public bool? SkipDuplicateCheck { get; set; }

            /// <summary>
            /// 关注配置：0 不处理， 1 自动关注（需要单独申请白名单）
            /// </summary>
            [NameInMap("subscribePolicy")]
            [Validation(Required=false)]
            public long? SubscribePolicy { get; set; }

            /// <summary>
            /// 保存联系人失败时是否阻断
            /// </summary>
            [NameInMap("throwExceptionWhileSavingContactFailed")]
            [Validation(Required=false)]
            public bool? ThrowExceptionWhileSavingContactFailed { get; set; }

        }

    }

}
