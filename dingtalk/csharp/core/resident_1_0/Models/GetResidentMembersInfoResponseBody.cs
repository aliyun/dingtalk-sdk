// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkresident_1_0.Models
{
    public class GetResidentMembersInfoResponseBody : TeaModel {
        /// <summary>
        /// result
        /// </summary>
        [NameInMap("residenceList")]
        [Validation(Required=false)]
        public List<GetResidentMembersInfoResponseBodyResidenceList> ResidenceList { get; set; }
        public class GetResidentMembersInfoResponseBodyResidenceList : TeaModel {
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 业主/租客/亲友等
            /// </summary>
            [NameInMap("relateType")]
            [Validation(Required=false)]
            public string RelateType { get; set; }

            /// <summary>
            /// 是否是产权人
            /// </summary>
            [NameInMap("isPropertyOwner")]
            [Validation(Required=false)]
            public bool? IsPropertyOwner { get; set; }

            /// <summary>
            /// 是否激活
            /// </summary>
            [NameInMap("active")]
            [Validation(Required=false)]
            public bool? Active { get; set; }

            /// <summary>
            /// 扩展字段，如果是租客存起止时间
            /// </summary>
            [NameInMap("extField")]
            [Validation(Required=false)]
            public string ExtField { get; set; }

        }

    }

}
