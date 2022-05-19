// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetUserStayLengthResponseBody : TeaModel {
        /// <summary>
        /// 员工使用时长列表
        /// </summary>
        [NameInMap("itemList")]
        [Validation(Required=false)]
        public List<GetUserStayLengthResponseBodyItemList> ItemList { get; set; }
        public class GetUserStayLengthResponseBodyItemList : TeaModel {
            /// <summary>
            /// 员工名称
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 统计日期
            /// </summary>
            [NameInMap("statDate")]
            [Validation(Required=false)]
            public string StatDate { get; set; }

            /// <summary>
            /// 1日app使用时长（秒）
            /// </summary>
            [NameInMap("stayTimeLenApp1d")]
            [Validation(Required=false)]
            public long? StayTimeLenApp1d { get; set; }

            /// <summary>
            /// 1日PC端使用时长（秒）
            /// </summary>
            [NameInMap("stayTimeLenPc1d")]
            [Validation(Required=false)]
            public long? StayTimeLenPc1d { get; set; }

            /// <summary>
            /// 工号
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// 总数据量
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
