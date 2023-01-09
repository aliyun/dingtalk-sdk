// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcard_1_0.Models
{
    public class UpdateCardRequest : TeaModel {
        /// <summary>
        /// 卡片数据
        /// </summary>
        [NameInMap("cardData")]
        [Validation(Required=false)]
        public UpdateCardRequestCardData CardData { get; set; }
        public class UpdateCardRequestCardData : TeaModel {
            /// <summary>
            /// 卡片模板内容替换参数，普通文本类型
            /// ● key：参数名
            /// ● value: 参数值
            /// </summary>
            [NameInMap("cardParamMap")]
            [Validation(Required=false)]
            public Dictionary<string, string> CardParamMap { get; set; }

        }

        /// <summary>
        /// 卡片更新选项
        /// </summary>
        [NameInMap("cardUpdateOptions")]
        [Validation(Required=false)]
        public UpdateCardRequestCardUpdateOptions CardUpdateOptions { get; set; }
        public class UpdateCardRequestCardUpdateOptions : TeaModel {
            /// <summary>
            /// 按 key 更新 cardData 数据，不填默认覆盖更新。
            /// </summary>
            [NameInMap("updateCardDataByKey")]
            [Validation(Required=false)]
            public bool? UpdateCardDataByKey { get; set; }

            /// <summary>
            /// 【可选】按key更新privateData用户数据，不填默认覆盖更新。
            /// </summary>
            [NameInMap("updatePrivateDataByKey")]
            [Validation(Required=false)]
            public bool? UpdatePrivateDataByKey { get; set; }

        }

        /// <summary>
        /// 【必填】外部卡片实例Id
        /// </summary>
        [NameInMap("outTrackId")]
        [Validation(Required=false)]
        public string OutTrackId { get; set; }

        /// <summary>
        /// 用户的私有数据。
        /// ● key：userId
        /// ● value：用户私有数据（cardData）
        /// </summary>
        [NameInMap("privateData")]
        [Validation(Required=false)]
        public Dictionary<string, PrivateDataValue> PrivateData { get; set; }

        [NameInMap("userIdType")]
        [Validation(Required=false)]
        public int? UserIdType { get; set; }

    }

}
