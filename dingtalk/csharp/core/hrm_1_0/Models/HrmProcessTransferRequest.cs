// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class HrmProcessTransferRequest : TeaModel {
        [NameInMap("deptIdsAfterTransfer")]
        [Validation(Required=false)]
        public List<long?> DeptIdsAfterTransfer { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>aefadfadaewedad</para>
        /// </summary>
        [NameInMap("jobIdAfterTransfer")]
        [Validation(Required=false)]
        public string JobIdAfterTransfer { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123L</para>
        /// </summary>
        [NameInMap("mainDeptIdAfterTransfer")]
        [Validation(Required=false)]
        public long? MainDeptIdAfterTransfer { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>232312312</para>
        /// </summary>
        [NameInMap("operateUserId")]
        [Validation(Required=false)]
        public string OperateUserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>fasdfaddsadfa</para>
        /// </summary>
        [NameInMap("positionIdAfterTransfer")]
        [Validation(Required=false)]
        public string PositionIdAfterTransfer { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>L1</para>
        /// </summary>
        [NameInMap("positionLevelAfterTransfer")]
        [Validation(Required=false)]
        public string PositionLevelAfterTransfer { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>经理</para>
        /// </summary>
        [NameInMap("positionNameAfterTransfer")]
        [Validation(Required=false)]
        public string PositionNameAfterTransfer { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>fasdfaddsadfa</para>
        /// </summary>
        [NameInMap("rankIdAfterTransfer")]
        [Validation(Required=false)]
        public string RankIdAfterTransfer { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2332</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
