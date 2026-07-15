// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class CardSubmitCardRequest : TeaModel {
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
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("cardBizId")]
        [Validation(Required=false)]
        public string CardBizId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("cardId")]
        [Validation(Required=false)]
        public string CardId { get; set; }

        [NameInMap("cardTaskCode")]
        [Validation(Required=false)]
        public string CardTaskCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("cardTaskId")]
        [Validation(Required=false)]
        public string CardTaskId { get; set; }

        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("detailUrl")]
        [Validation(Required=false)]
        public string DetailUrl { get; set; }

        [NameInMap("editUrl")]
        [Validation(Required=false)]
        public string EditUrl { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("medias")]
        [Validation(Required=false)]
        public string Medias { get; set; }

        [NameInMap("meteringNumber")]
        [Validation(Required=false)]
        public double? MeteringNumber { get; set; }

        [NameInMap("reissueCard")]
        [Validation(Required=false)]
        public bool? ReissueCard { get; set; }

        [NameInMap("resultEvaluation")]
        [Validation(Required=false)]
        public string ResultEvaluation { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("sourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        [NameInMap("specifiedStudentId")]
        [Validation(Required=false)]
        public string SpecifiedStudentId { get; set; }

        [NameInMap("unitOfMeasurement")]
        [Validation(Required=false)]
        public string UnitOfMeasurement { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
