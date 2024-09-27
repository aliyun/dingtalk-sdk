// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class CardEndCardRequest : TeaModel {
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
        /// <para>YUFANAI</para>
        /// </summary>
        [NameInMap("sourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

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
