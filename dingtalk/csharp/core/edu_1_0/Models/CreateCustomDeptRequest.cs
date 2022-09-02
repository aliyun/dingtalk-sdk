// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class CreateCustomDeptRequest : TeaModel {
        [NameInMap("customDept")]
        [Validation(Required=false)]
        public CreateCustomDeptRequestCustomDept CustomDept { get; set; }
        public class CreateCustomDeptRequestCustomDept : TeaModel {
            /// <summary>
            /// 自定义校区或部门名称
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 部门类型：custom_campus: 自定义校区；custom_dept: 自定义部门
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// 钉钉管理员员工ID
        /// </summary>
        [NameInMap("operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        /// <summary>
        /// 上级部门ID（type为custom_campus时，必须为-7）
        /// </summary>
        [NameInMap("superId")]
        [Validation(Required=false)]
        public long? SuperId { get; set; }

    }

}
