// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkresident_1_0.Models
{
    public class AddResidentUsersRequest : TeaModel {
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
        public List<AddResidentUsersRequestExtField> ExtField { get; set; }
        public class AddResidentUsersRequestExtField : TeaModel {
            [NameInMap("itemName")]
            [Validation(Required=false)]
            public string ItemName { get; set; }

            [NameInMap("itemValue")]
            [Validation(Required=false)]
            public string ItemValue { get; set; }

        }

        [NameInMap("isLeaseholder")]
        [Validation(Required=false)]
        public bool? IsLeaseholder { get; set; }

        [NameInMap("mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        [NameInMap("relateType")]
        [Validation(Required=false)]
        public string RelateType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("userName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
