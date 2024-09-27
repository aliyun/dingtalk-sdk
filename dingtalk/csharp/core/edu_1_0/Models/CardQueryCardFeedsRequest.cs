// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class CardQueryCardFeedsRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("bizType")]
        [Validation(Required=false)]
        public int? BizType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>industry_center</para>
        /// </summary>
        [NameInMap("cardBizCode")]
        [Validation(Required=false)]
        public string CardBizCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>856237470</para>
        /// </summary>
        [NameInMap("cardBizId")]
        [Validation(Required=false)]
        public string CardBizId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80264668258</para>
        /// </summary>
        [NameInMap("cardId")]
        [Validation(Required=false)]
        public long? CardId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("cursor")]
        [Validation(Required=false)]
        public long? Cursor { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("feedType")]
        [Validation(Required=false)]
        public int? FeedType { get; set; }

        [NameInMap("needFinishProcess")]
        [Validation(Required=false)]
        public bool? NeedFinishProcess { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>YUFANAI</para>
        /// </summary>
        [NameInMap("sourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3000000000847390208</para>
        /// </summary>
        [NameInMap("studentId")]
        [Validation(Required=false)]
        public string StudentId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CARD_TASK_CODE_0</para>
        /// </summary>
        [NameInMap("subBizId")]
        [Validation(Required=false)]
        public string SubBizId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>manager7741</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
