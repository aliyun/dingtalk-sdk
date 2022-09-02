// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class CreateCustomClassRequest : TeaModel {
        /// <summary>
        /// 班级信息
        /// </summary>
        [NameInMap("customClass")]
        [Validation(Required=false)]
        public CreateCustomClassRequestCustomClass CustomClass { get; set; }
        public class CreateCustomClassRequestCustomClass : TeaModel {
            /// <summary>
            /// 班级名称
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// 钉钉企业管理员工ID
        /// </summary>
        [NameInMap("operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        /// <summary>
        /// 上级部门ID
        /// </summary>
        [NameInMap("superId")]
        [Validation(Required=false)]
        public long? SuperId { get; set; }

    }

}
