// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkorg_culture_1_0.Models
{
    public class AssignOrgHoldingToEmpHoldingBatchRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>表现优秀，特此奖励</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("sendOrgCultureInform")]
        [Validation(Required=false)]
        public bool? SendOrgCultureInform { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("singleAmount")]
        [Validation(Required=false)]
        public long? SingleAmount { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OPEN_ORG_POINT_PERSONAL_ASSIGN</para>
        /// </summary>
        [NameInMap("sourceUsage")]
        [Validation(Required=false)]
        public string SourceUsage { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OPEN_EMP_POINT_PERSONAL_RECEIVE</para>
        /// </summary>
        [NameInMap("targetUsage")]
        [Validation(Required=false)]
        public string TargetUsage { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("targetUserList")]
        [Validation(Required=false)]
        public List<AssignOrgHoldingToEmpHoldingBatchRequestTargetUserList> TargetUserList { get; set; }
        public class AssignOrgHoldingToEmpHoldingBatchRequestTargetUserList : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4353453454241</para>
            /// </summary>
            [NameInMap("outId")]
            [Validation(Required=false)]
            public string OutId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>551341216920908910</para>
            /// </summary>
            [NameInMap("targetUserId")]
            [Validation(Required=false)]
            public string TargetUserId { get; set; }

        }

    }

}
