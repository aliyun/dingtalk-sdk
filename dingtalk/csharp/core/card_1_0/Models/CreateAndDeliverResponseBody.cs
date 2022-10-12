// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcard_1_0.Models
{
    public class CreateAndDeliverResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateAndDeliverResponseBodyResult Result { get; set; }
        public class CreateAndDeliverResponseBodyResult : TeaModel {
            /// <summary>
            /// 投放结果
            /// </summary>
            [NameInMap("deliverResults")]
            [Validation(Required=false)]
            public List<CreateAndDeliverResponseBodyResultDeliverResults> DeliverResults { get; set; }
            public class CreateAndDeliverResponseBodyResultDeliverResults : TeaModel {
                /// <summary>
                /// 错误信息
                /// </summary>
                [NameInMap("errorMsg")]
                [Validation(Required=false)]
                public string ErrorMsg { get; set; }

                /// <summary>
                /// 场域Id
                /// </summary>
                [NameInMap("spaceId")]
                [Validation(Required=false)]
                public string SpaceId { get; set; }

                /// <summary>
                /// 场域类型 (IM: IM类型，包括群聊和单聊，仅供返回结果使用, IM_SINGLE: IM单聊, IM_GROUP: IM群聊, ONE_BOX: 群吊顶, COOPERATION_FEED: 协作, WORK_BENCH: 工作台)
                /// </summary>
                [NameInMap("spaceType")]
                [Validation(Required=false)]
                public string SpaceType { get; set; }

                /// <summary>
                /// 投放成功
                /// </summary>
                [NameInMap("success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

            }

            /// <summary>
            /// 外部卡片实例Id
            /// </summary>
            [NameInMap("outTrackId")]
            [Validation(Required=false)]
            public string OutTrackId { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
