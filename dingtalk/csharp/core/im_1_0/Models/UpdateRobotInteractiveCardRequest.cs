// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class UpdateRobotInteractiveCardRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cardXXXX01</para>
        /// </summary>
        [NameInMap("cardBizId")]
        [Validation(Required=false)]
        public string CardBizId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>根据具体的cardTemplateId参考文档格式</para>
        /// </summary>
        [NameInMap("cardData")]
        [Validation(Required=false)]
        public string CardData { get; set; }

        [NameInMap("unionIdPrivateDataMap")]
        [Validation(Required=false)]
        public string UnionIdPrivateDataMap { get; set; }

        [NameInMap("updateOptions")]
        [Validation(Required=false)]
        public UpdateRobotInteractiveCardRequestUpdateOptions UpdateOptions { get; set; }
        public class UpdateRobotInteractiveCardRequestUpdateOptions : TeaModel {
            [NameInMap("updateCardDataByKey")]
            [Validation(Required=false)]
            public bool? UpdateCardDataByKey { get; set; }

            [NameInMap("updatePrivateDataByKey")]
            [Validation(Required=false)]
            public bool? UpdatePrivateDataByKey { get; set; }

        }

        [NameInMap("userIdPrivateDataMap")]
        [Validation(Required=false)]
        public string UserIdPrivateDataMap { get; set; }

    }

}
