// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkorg_culture_1_0.Models
{
    public class DeductionPointBatchRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("deductionAmount")]
        [Validation(Required=false)]
        public long? DeductionAmount { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>表现不佳，以此惩罚。</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>组织文化通知扣减原因</para>
        /// </summary>
        [NameInMap("sendOrgCultureInform")]
        [Validation(Required=false)]
        public bool? SendOrgCultureInform { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("targetUserList")]
        [Validation(Required=false)]
        public List<DeductionPointBatchRequestTargetUserList> TargetUserList { get; set; }
        public class DeductionPointBatchRequestTargetUserList : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>232344342</para>
            /// </summary>
            [NameInMap("outId")]
            [Validation(Required=false)]
            public string OutId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>01274411491620908910</para>
            /// </summary>
            [NameInMap("targetUserId")]
            [Validation(Required=false)]
            public string TargetUserId { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01274411491620908910</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
