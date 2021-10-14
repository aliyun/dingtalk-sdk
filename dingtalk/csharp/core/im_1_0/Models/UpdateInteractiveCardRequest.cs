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
            [NameInMap("cardMediaIdParamMap")]
            [Validation(Required=false)]
            public Dictionary<string, string> CardMediaIdParamMap { get; set; }
            [NameInMap("cardParamMap")]
            [Validation(Required=false)]
            public Dictionary<string, string> CardParamMap { get; set; }
        };

        /// <summary>
        /// 发送可交互卡片的一些功能选项
        /// </summary>
        [NameInMap("cardOptions")]
        [Validation(Required=false)]
        public UpdateInteractiveCardRequestCardOptions CardOptions { get; set; }
        public class UpdateInteractiveCardRequestCardOptions : TeaModel {
            [NameInMap("updateCardDataByKey")]
            [Validation(Required=false)]
            public bool? UpdateCardDataByKey { get; set; }
            [NameInMap("updatePrivateDataByKey")]
            [Validation(Required=false)]
            public bool? UpdatePrivateDataByKey { get; set; }
        };

        [NameInMap("dingIsvOrgId")]
        [Validation(Required=false)]
        public long? DingIsvOrgId { get; set; }

        [NameInMap("dingOauthAppId")]
        [Validation(Required=false)]
        public long? DingOauthAppId { get; set; }

        [NameInMap("dingOrgId")]
        [Validation(Required=false)]
        public long? DingOrgId { get; set; }

        [NameInMap("dingSuiteKey")]
        [Validation(Required=false)]
        public string DingSuiteKey { get; set; }

        [NameInMap("dingTokenGrantType")]
        [Validation(Required=false)]
        public long? DingTokenGrantType { get; set; }

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
