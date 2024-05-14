// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkresident_1_0.Models
{
    public class UpdateResidentUserRequest : TeaModel {
        [NameInMap("address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("departmentId")]
        [Validation(Required=false)]
        public long? DepartmentId { get; set; }

        [NameInMap("extField")]
        [Validation(Required=false)]
        public List<UpdateResidentUserRequestExtField> ExtField { get; set; }
        public class UpdateResidentUserRequestExtField : TeaModel {
            [NameInMap("itemName")]
            [Validation(Required=false)]
            public string ItemName { get; set; }

            [NameInMap("itemValue")]
            [Validation(Required=false)]
            public string ItemValue { get; set; }

        }

        [NameInMap("isRetainOldDept")]
        [Validation(Required=false)]
        public bool? IsRetainOldDept { get; set; }

        [NameInMap("mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("oldDepartmentId")]
        [Validation(Required=false)]
        public long? OldDepartmentId { get; set; }

        [NameInMap("relateType")]
        [Validation(Required=false)]
        public string RelateType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("userName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
