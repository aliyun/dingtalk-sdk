// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class CollegeListDeptManagerResponseBody : TeaModel {
        /// <summary>
        /// 负责人信息列表
        /// </summary>
        [NameInMap("managerInfoSimpleList")]
        [Validation(Required=false)]
        public List<CollegeListDeptManagerResponseBodyManagerInfoSimpleList> ManagerInfoSimpleList { get; set; }
        public class CollegeListDeptManagerResponseBodyManagerInfoSimpleList : TeaModel {
            /// <summary>
            /// 账号是否激活
            /// </summary>
            [NameInMap("isActive")]
            [Validation(Required=false)]
            public bool? IsActive { get; set; }

            /// <summary>
            /// 负责人姓名
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// userId
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// 数据总条目数
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
