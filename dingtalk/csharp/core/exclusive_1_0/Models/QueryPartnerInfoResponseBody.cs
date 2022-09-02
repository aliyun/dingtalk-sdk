// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class QueryPartnerInfoResponseBody : TeaModel {
        /// <summary>
        /// 部门列表
        /// </summary>
        [NameInMap("partnerDeptList")]
        [Validation(Required=false)]
        public List<QueryPartnerInfoResponseBodyPartnerDeptList> PartnerDeptList { get; set; }
        public class QueryPartnerInfoResponseBodyPartnerDeptList : TeaModel {
            /// <summary>
            /// 部门人数
            /// </summary>
            [NameInMap("memberCount")]
            [Validation(Required=false)]
            public long? MemberCount { get; set; }

            /// <summary>
            /// 一级伙伴类型
            /// </summary>
            [NameInMap("partnerLabelModelLevel1")]
            [Validation(Required=false)]
            public QueryPartnerInfoResponseBodyPartnerDeptListPartnerLabelModelLevel1 PartnerLabelModelLevel1 { get; set; }
            public class QueryPartnerInfoResponseBodyPartnerDeptListPartnerLabelModelLevel1 : TeaModel {
                /// <summary>
                /// 标签id
                /// </summary>
                [NameInMap("labelId")]
                [Validation(Required=false)]
                public long? LabelId { get; set; }

                /// <summary>
                /// 标签名称
                /// </summary>
                [NameInMap("labelname")]
                [Validation(Required=false)]
                public string Labelname { get; set; }

            }

            /// <summary>
            /// 伙伴编码
            /// </summary>
            [NameInMap("partnerNum")]
            [Validation(Required=false)]
            public string PartnerNum { get; set; }

            /// <summary>
            /// 部门名称
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// 部门id
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// 伙伴标签
        /// </summary>
        [NameInMap("partnerLabelList")]
        [Validation(Required=false)]
        public List<QueryPartnerInfoResponseBodyPartnerLabelList> PartnerLabelList { get; set; }
        public class QueryPartnerInfoResponseBodyPartnerLabelList : TeaModel {
            /// <summary>
            /// label id
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// label value
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// 员工id
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
