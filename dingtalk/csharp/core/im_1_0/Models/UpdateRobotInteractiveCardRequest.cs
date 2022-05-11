// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class UpdateRobotInteractiveCardRequest : TeaModel {
        /// <summary>
        /// 唯一标识一张卡片的外部ID（卡片幂等ID，可用于更新或重复发送同一卡片到多个群会话）【备注：同一个outTrackId重复创建，卡片数据不覆盖更新】
        /// </summary>
        [NameInMap("cardBizId")]
        [Validation(Required=false)]
        public string CardBizId { get; set; }

        /// <summary>
        /// 卡片模板-文本内容参数（卡片json结构体）
        /// </summary>
        [NameInMap("cardData")]
        [Validation(Required=false)]
        public string CardData { get; set; }

        /// <summary>
        /// 卡片模板-userId差异用户参数（json结构体）
        /// </summary>
        [NameInMap("unionIdPrivateDataMap")]
        [Validation(Required=false)]
        public string UnionIdPrivateDataMap { get; set; }

        /// <summary>
        /// 互动卡片更新选项
        /// </summary>
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
        };

        /// <summary>
        /// 卡片模板-userId差异用户参数（json结构体）
        /// </summary>
        [NameInMap("userIdPrivateDataMap")]
        [Validation(Required=false)]
        public string UserIdPrivateDataMap { get; set; }

    }

}
