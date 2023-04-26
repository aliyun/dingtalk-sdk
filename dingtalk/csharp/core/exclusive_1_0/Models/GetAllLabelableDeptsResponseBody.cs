// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetAllLabelableDeptsResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetAllLabelableDeptsResponseBodyData> Data { get; set; }
        public class GetAllLabelableDeptsResponseBodyData : TeaModel {
            [NameInMap("deptId")]
            [Validation(Required=false)]
            public string DeptId { get; set; }

            [NameInMap("deptName")]
            [Validation(Required=false)]
            public string DeptName { get; set; }

            [NameInMap("memberCount")]
            [Validation(Required=false)]
            public long? MemberCount { get; set; }

            [NameInMap("partnerLabelVOLevel1")]
            [Validation(Required=false)]
            public GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel1 PartnerLabelVOLevel1 { get; set; }
            public class GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel1 : TeaModel {
                [NameInMap("labelId")]
                [Validation(Required=false)]
                public long? LabelId { get; set; }

                [NameInMap("labelName")]
                [Validation(Required=false)]
                public string LabelName { get; set; }

                [NameInMap("levelNum")]
                [Validation(Required=false)]
                public long? LevelNum { get; set; }

            }

            [NameInMap("partnerLabelVOLevel2")]
            [Validation(Required=false)]
            public GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel2 PartnerLabelVOLevel2 { get; set; }
            public class GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel2 : TeaModel {
                [NameInMap("labelId")]
                [Validation(Required=false)]
                public long? LabelId { get; set; }

                [NameInMap("labelName")]
                [Validation(Required=false)]
                public string LabelName { get; set; }

                [NameInMap("levelNum")]
                [Validation(Required=false)]
                public long? LevelNum { get; set; }

            }

            [NameInMap("partnerLabelVOLevel3")]
            [Validation(Required=false)]
            public GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel3 PartnerLabelVOLevel3 { get; set; }
            public class GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel3 : TeaModel {
                [NameInMap("labelId")]
                [Validation(Required=false)]
                public long? LabelId { get; set; }

                [NameInMap("labelName")]
                [Validation(Required=false)]
                public string LabelName { get; set; }

                [NameInMap("levelNum")]
                [Validation(Required=false)]
                public long? LevelNum { get; set; }

            }

            [NameInMap("partnerLabelVOLevel4")]
            [Validation(Required=false)]
            public GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel4 PartnerLabelVOLevel4 { get; set; }
            public class GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel4 : TeaModel {
                [NameInMap("labelId")]
                [Validation(Required=false)]
                public long? LabelId { get; set; }

                [NameInMap("labelName")]
                [Validation(Required=false)]
                public string LabelName { get; set; }

                [NameInMap("levelNum")]
                [Validation(Required=false)]
                public long? LevelNum { get; set; }

            }

            [NameInMap("partnerLabelVOLevel5")]
            [Validation(Required=false)]
            public GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel5 PartnerLabelVOLevel5 { get; set; }
            public class GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel5 : TeaModel {
                [NameInMap("labelId")]
                [Validation(Required=false)]
                public long? LabelId { get; set; }

                [NameInMap("labelName")]
                [Validation(Required=false)]
                public string LabelName { get; set; }

                [NameInMap("levelNum")]
                [Validation(Required=false)]
                public long? LevelNum { get; set; }

            }

            [NameInMap("partnerNum")]
            [Validation(Required=false)]
            public string PartnerNum { get; set; }

            [NameInMap("superDeptId")]
            [Validation(Required=false)]
            public string SuperDeptId { get; set; }

        }

    }

}
