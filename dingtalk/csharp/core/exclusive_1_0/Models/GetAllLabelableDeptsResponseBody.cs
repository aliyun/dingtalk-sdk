// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetAllLabelableDeptsResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetAllLabelableDeptsResponseBodyData> Data { get; set; }
        public class GetAllLabelableDeptsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("deptId")]
            [Validation(Required=false)]
            public string DeptId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>管理部</para>
            /// </summary>
            [NameInMap("deptName")]
            [Validation(Required=false)]
            public string DeptName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("memberCount")]
            [Validation(Required=false)]
            public long? MemberCount { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("partnerLabelVOLevel1")]
            [Validation(Required=false)]
            public GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel1 PartnerLabelVOLevel1 { get; set; }
            public class GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel1 : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("labelId")]
                [Validation(Required=false)]
                public long? LabelId { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>一级供应商</para>
                /// </summary>
                [NameInMap("labelName")]
                [Validation(Required=false)]
                public string LabelName { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("levelNum")]
                [Validation(Required=false)]
                public long? LevelNum { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("partnerLabelVOLevel2")]
            [Validation(Required=false)]
            public GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel2 PartnerLabelVOLevel2 { get; set; }
            public class GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel2 : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("labelId")]
                [Validation(Required=false)]
                public long? LabelId { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>二级供应商</para>
                /// </summary>
                [NameInMap("labelName")]
                [Validation(Required=false)]
                public string LabelName { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("levelNum")]
                [Validation(Required=false)]
                public long? LevelNum { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("partnerLabelVOLevel3")]
            [Validation(Required=false)]
            public GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel3 PartnerLabelVOLevel3 { get; set; }
            public class GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel3 : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("labelId")]
                [Validation(Required=false)]
                public long? LabelId { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>三级供应商</para>
                /// </summary>
                [NameInMap("labelName")]
                [Validation(Required=false)]
                public string LabelName { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("levelNum")]
                [Validation(Required=false)]
                public long? LevelNum { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("partnerLabelVOLevel4")]
            [Validation(Required=false)]
            public GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel4 PartnerLabelVOLevel4 { get; set; }
            public class GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel4 : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("labelId")]
                [Validation(Required=false)]
                public long? LabelId { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>四级供应商</para>
                /// </summary>
                [NameInMap("labelName")]
                [Validation(Required=false)]
                public string LabelName { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("levelNum")]
                [Validation(Required=false)]
                public long? LevelNum { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("partnerLabelVOLevel5")]
            [Validation(Required=false)]
            public GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel5 PartnerLabelVOLevel5 { get; set; }
            public class GetAllLabelableDeptsResponseBodyDataPartnerLabelVOLevel5 : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("labelId")]
                [Validation(Required=false)]
                public long? LabelId { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>五级供应商</para>
                /// </summary>
                [NameInMap("labelName")]
                [Validation(Required=false)]
                public string LabelName { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("levelNum")]
                [Validation(Required=false)]
                public long? LevelNum { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("partnerNum")]
            [Validation(Required=false)]
            public string PartnerNum { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("superDeptId")]
            [Validation(Required=false)]
            public string SuperDeptId { get; set; }

        }

    }

}
