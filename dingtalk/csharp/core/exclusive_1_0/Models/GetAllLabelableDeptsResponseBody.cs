// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetAllLabelableDeptsResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetAllLabelableDeptsResponseBodyData> Data { get; set; }
        public class GetAllLabelableDeptsResponseBodyData : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("deptId")]
            [Validation(Required=false)]
            public string DeptId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("deptName")]
            [Validation(Required=false)]
            public string DeptName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("memberCount")]
            [Validation(Required=false)]
            public long? MemberCount { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("partnerLabelVOLevel1")]
            [Validation(Required=false)]
            public GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel1 PartnerLabelVOLevel1 { get; set; }
            public class GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel1 : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("labelId")]
                [Validation(Required=false)]
                public long? LabelId { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("labelName")]
                [Validation(Required=false)]
                public string LabelName { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("levelNum")]
                [Validation(Required=false)]
                public long? LevelNum { get; set; }

            }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("partnerLabelVOLevel2")]
            [Validation(Required=false)]
            public GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel2 PartnerLabelVOLevel2 { get; set; }
            public class GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel2 : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("labelId")]
                [Validation(Required=false)]
                public long? LabelId { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("labelName")]
                [Validation(Required=false)]
                public string LabelName { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("levelNum")]
                [Validation(Required=false)]
                public long? LevelNum { get; set; }

            }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("partnerLabelVOLevel3")]
            [Validation(Required=false)]
            public GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel3 PartnerLabelVOLevel3 { get; set; }
            public class GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel3 : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("labelId")]
                [Validation(Required=false)]
                public long? LabelId { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("labelName")]
                [Validation(Required=false)]
                public string LabelName { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("levelNum")]
                [Validation(Required=false)]
                public long? LevelNum { get; set; }

            }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("partnerLabelVOLevel4")]
            [Validation(Required=false)]
            public GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel4 PartnerLabelVOLevel4 { get; set; }
            public class GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel4 : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("labelId")]
                [Validation(Required=false)]
                public long? LabelId { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("labelName")]
                [Validation(Required=false)]
                public string LabelName { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("levelNum")]
                [Validation(Required=false)]
                public long? LevelNum { get; set; }

            }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("partnerLabelVOLevel5")]
            [Validation(Required=false)]
            public GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel5 PartnerLabelVOLevel5 { get; set; }
            public class GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel5 : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("labelId")]
                [Validation(Required=false)]
                public long? LabelId { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("labelName")]
                [Validation(Required=false)]
                public string LabelName { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("levelNum")]
                [Validation(Required=false)]
                public long? LevelNum { get; set; }

            }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("partnerNum")]
            [Validation(Required=false)]
            public string PartnerNum { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("superDeptId")]
            [Validation(Required=false)]
            public string SuperDeptId { get; set; }

        }

    }

}
