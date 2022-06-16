// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class QueryDepartmentInfoResponseBody : TeaModel {
        /// <summary>
        /// 科室详情
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public QueryDepartmentInfoResponseBodyContent Content { get; set; }
        public class QueryDepartmentInfoResponseBodyContent : TeaModel {
            [NameInMap("department")]
            [Validation(Required=false)]
            public QueryDepartmentInfoResponseBodyContentDepartment Department { get; set; }
            public class QueryDepartmentInfoResponseBodyContentDepartment : TeaModel {
                /// <summary>
                /// 科室code
                /// </summary>
                [NameInMap("deptCode")]
                [Validation(Required=false)]
                public string DeptCode { get; set; }

                /// <summary>
                /// 科室名称
                /// </summary>
                [NameInMap("deptName")]
                [Validation(Required=false)]
                public string DeptName { get; set; }

                /// <summary>
                /// 顺序
                /// </summary>
                [NameInMap("deptOrder")]
                [Validation(Required=false)]
                public long? DeptOrder { get; set; }

                /// <summary>
                /// 状态
                /// </summary>
                [NameInMap("deptStatus")]
                [Validation(Required=false)]
                public int? DeptStatus { get; set; }

                /// <summary>
                /// 类型
                /// </summary>
                [NameInMap("deptType")]
                [Validation(Required=false)]
                public int? DeptType { get; set; }

                /// <summary>
                /// 创建时间
                /// </summary>
                [NameInMap("gmtCreateStr")]
                [Validation(Required=false)]
                public string GmtCreateStr { get; set; }

                /// <summary>
                /// 修改时间
                /// </summary>
                [NameInMap("gmtModifiedStr")]
                [Validation(Required=false)]
                public string GmtModifiedStr { get; set; }

                /// <summary>
                /// 科室id
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// 科室名称
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// 父code
                /// </summary>
                [NameInMap("parentDeptCode")]
                [Validation(Required=false)]
                public string ParentDeptCode { get; set; }

                /// <summary>
                /// 备注
                /// </summary>
                [NameInMap("remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// 病区id
                /// </summary>
                [NameInMap("wardIdList")]
                [Validation(Required=false)]
                public List<long?> WardIdList { get; set; }

            }
            [NameInMap("extendInfos")]
            [Validation(Required=false)]
            public List<QueryDepartmentInfoResponseBodyContentExtendInfos> ExtendInfos { get; set; }
            public class QueryDepartmentInfoResponseBodyContentExtendInfos : TeaModel {
                public string DeptCode { get; set; }
                public string DeptExtendDisplayName { get; set; }
                public string DeptExtendKey { get; set; }
                public string DeptExtendValue { get; set; }
                public string GmtCreateStr { get; set; }
                public string GmtModifiedStr { get; set; }
                public long? Id { get; set; }
                public int? Status { get; set; }
            }
        };

    }

}
