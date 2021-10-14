// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkresident_1_0.Models
{
    public class AddResidentUsersRequest : TeaModel {
        /// <summary>
        /// 家庭住址
        /// </summary>
        [NameInMap("address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// 户/租户部门id
        /// </summary>
        [NameInMap("departmentId")]
        [Validation(Required=false)]
        public long? DepartmentId { get; set; }

        /// <summary>
        /// 扩展字段（包括身份证/性别/民族）
        /// </summary>
        [NameInMap("extField")]
        [Validation(Required=false)]
        public List<AddResidentUsersRequestExtField> ExtField { get; set; }
        public class AddResidentUsersRequestExtField : TeaModel {
            /// <summary>
            /// 扩展字段值
            /// </summary>
            [NameInMap("itemValue")]
            [Validation(Required=false)]
            public string ItemValue { get; set; }

            /// <summary>
            /// 扩展字段名字
            /// </summary>
            [NameInMap("itemName")]
            [Validation(Required=false)]
            public string ItemName { get; set; }

        }

        /// <summary>
        /// 是否是租客
        /// </summary>
        [NameInMap("isLeaseholder")]
        [Validation(Required=false)]
        public bool? IsLeaseholder { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        [NameInMap("mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        /// <summary>
        /// 与户主的关系
        /// </summary>
        [NameInMap("relateType")]
        [Validation(Required=false)]
        public string RelateType { get; set; }

        /// <summary>
        /// 居民名字
        /// </summary>
        [NameInMap("userName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
