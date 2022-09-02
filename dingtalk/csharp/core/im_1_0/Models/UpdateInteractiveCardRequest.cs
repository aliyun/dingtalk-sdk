// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class UpdateInteractiveCardRequest : TeaModel {
        /// <summary>
        /// 卡片公共主体部分数据
        /// </summary>
        [NameInMap("cardData")]
        [Validation(Required=false)]
        public UpdateInteractiveCardRequestCardData CardData { get; set; }
        public class UpdateInteractiveCardRequestCardData : TeaModel {
            /// <summary>
            /// 卡片模板内容替换参数-多媒体类型
            /// </summary>
            [NameInMap("cardMediaIdParamMap")]
            [Validation(Required=false)]
            public Dictionary<string, string> CardMediaIdParamMap { get; set; }

            /// <summary>
            /// 卡片模板内容替换参数-普通文本类型
            /// </summary>
            [NameInMap("cardParamMap")]
            [Validation(Required=false)]
            public Dictionary<string, string> CardParamMap { get; set; }

        }

        /// <summary>
        /// 发送可交互卡片的一些功能选项
        /// </summary>
        [NameInMap("cardOptions")]
        [Validation(Required=false)]
        public UpdateInteractiveCardRequestCardOptions CardOptions { get; set; }
        public class UpdateInteractiveCardRequestCardOptions : TeaModel {
            /// <summary>
            /// 按key更新cardData数据(不填默认覆盖更新)
            /// </summary>
            [NameInMap("updateCardDataByKey")]
            [Validation(Required=false)]
            public bool? UpdateCardDataByKey { get; set; }

            /// <summary>
            /// 按key更新privateData用户数据(不填默认覆盖更新)
            /// </summary>
            [NameInMap("updatePrivateDataByKey")]
            [Validation(Required=false)]
            public bool? UpdatePrivateDataByKey { get; set; }

        }

        /// <summary>
        /// 唯一标识一张卡片的外部ID
        /// </summary>
        [NameInMap("outTrackId")]
        [Validation(Required=false)]
        public string OutTrackId { get; set; }

        /// <summary>
        /// 卡片用户私有差异部分数据（如卡片不同人显示不同按钮；key：用户userId；value：用户数据变量）
        /// </summary>
        [NameInMap("privateData")]
        [Validation(Required=false)]
        public Dictionary<string, PrivateDataValue> PrivateData { get; set; }

        /// <summary>
        /// 用户ID类型：1：userId模式【默认】；2：unionId模式；对应receiverUserIdList、privateData字段关于用户id的值填写方式
        /// </summary>
        [NameInMap("userIdType")]
        [Validation(Required=false)]
        public int? UserIdType { get; set; }

    }

}
