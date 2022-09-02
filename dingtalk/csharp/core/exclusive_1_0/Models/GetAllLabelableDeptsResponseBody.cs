// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetAllLabelableDeptsResponseBody : TeaModel {
        /// <summary>
        /// 伙伴钉可打标部门列表
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetAllLabelableDeptsResponseBodyData> Data { get; set; }
        public class GetAllLabelableDeptsResponseBodyData : TeaModel {
            /// <summary>
            /// 部门id
            /// </summary>
            [NameInMap("deptId")]
            [Validation(Required=false)]
            public string DeptId { get; set; }

            /// <summary>
            /// 部门名称
            /// </summary>
            [NameInMap("deptName")]
            [Validation(Required=false)]
            public string DeptName { get; set; }

            /// <summary>
            /// 部门人数
            /// </summary>
            [NameInMap("memberCount")]
            [Validation(Required=false)]
            public long? MemberCount { get; set; }

            /// <summary>
            /// 部门一级伙伴类型
            /// </summary>
            [NameInMap("partnerLabelVOLevel1")]
            [Validation(Required=false)]
            public GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel1 PartnerLabelVOLevel1 { get; set; }
            public class GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel1 : TeaModel {
                /// <summary>
                /// 伙伴类型id
                /// </summary>
                [NameInMap("labelId")]
                [Validation(Required=false)]
                public long? LabelId { get; set; }

                /// <summary>
                /// 伙伴类型
                /// </summary>
                [NameInMap("labelName")]
                [Validation(Required=false)]
                public string LabelName { get; set; }

                /// <summary>
                /// 伙伴类型层级
                /// </summary>
                [NameInMap("levelNum")]
                [Validation(Required=false)]
                public long? LevelNum { get; set; }

            }

            /// <summary>
            /// 部门二级伙伴类型
            /// </summary>
            [NameInMap("partnerLabelVOLevel2")]
            [Validation(Required=false)]
            public GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel2 PartnerLabelVOLevel2 { get; set; }
            public class GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel2 : TeaModel {
                /// <summary>
                /// 伙伴类型id
                /// </summary>
                [NameInMap("labelId")]
                [Validation(Required=false)]
                public long? LabelId { get; set; }

                /// <summary>
                /// 伙伴类型
                /// </summary>
                [NameInMap("labelName")]
                [Validation(Required=false)]
                public string LabelName { get; set; }

                /// <summary>
                /// 伙伴类型层级
                /// </summary>
                [NameInMap("levelNum")]
                [Validation(Required=false)]
                public long? LevelNum { get; set; }

            }

            /// <summary>
            /// 部门三级伙伴类型
            /// </summary>
            [NameInMap("partnerLabelVOLevel3")]
            [Validation(Required=false)]
            public GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel3 PartnerLabelVOLevel3 { get; set; }
            public class GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel3 : TeaModel {
                /// <summary>
                /// 伙伴类型id
                /// </summary>
                [NameInMap("labelId")]
                [Validation(Required=false)]
                public long? LabelId { get; set; }

                /// <summary>
                /// 伙伴类型
                /// </summary>
                [NameInMap("labelName")]
                [Validation(Required=false)]
                public string LabelName { get; set; }

                /// <summary>
                /// 伙伴类型层级
                /// </summary>
                [NameInMap("levelNum")]
                [Validation(Required=false)]
                public long? LevelNum { get; set; }

            }

            /// <summary>
            /// 部门四级伙伴类型
            /// </summary>
            [NameInMap("partnerLabelVOLevel4")]
            [Validation(Required=false)]
            public GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel4 PartnerLabelVOLevel4 { get; set; }
            public class GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel4 : TeaModel {
                /// <summary>
                /// 伙伴类型id
                /// </summary>
                [NameInMap("labelId")]
                [Validation(Required=false)]
                public long? LabelId { get; set; }

                /// <summary>
                /// 伙伴类型
                /// </summary>
                [NameInMap("labelName")]
                [Validation(Required=false)]
                public string LabelName { get; set; }

                /// <summary>
                /// 伙伴类型层级
                /// </summary>
                [NameInMap("levelNum")]
                [Validation(Required=false)]
                public long? LevelNum { get; set; }

            }

            /// <summary>
            /// 部门五级伙伴类型
            /// </summary>
            [NameInMap("partnerLabelVOLevel5")]
            [Validation(Required=false)]
            public GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel5 PartnerLabelVOLevel5 { get; set; }
            public class GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel5 : TeaModel {
                /// <summary>
                /// 伙伴类型id
                /// </summary>
                [NameInMap("labelId")]
                [Validation(Required=false)]
                public long? LabelId { get; set; }

                /// <summary>
                /// 伙伴类型
                /// </summary>
                [NameInMap("labelName")]
                [Validation(Required=false)]
                public string LabelName { get; set; }

                /// <summary>
                /// 伙伴类型层级
                /// </summary>
                [NameInMap("levelNum")]
                [Validation(Required=false)]
                public long? LevelNum { get; set; }

            }

            /// <summary>
            /// 部门伙伴编码
            /// </summary>
            [NameInMap("partnerNum")]
            [Validation(Required=false)]
            public string PartnerNum { get; set; }

            /// <summary>
            /// 父部门id
            /// </summary>
            [NameInMap("superDeptId")]
            [Validation(Required=false)]
            public string SuperDeptId { get; set; }

        }

    }

}
