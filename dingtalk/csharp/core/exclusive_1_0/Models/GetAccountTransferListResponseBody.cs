// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetAccountTransferListResponseBody : TeaModel {
        /// <summary>
        /// 迁移详情数据
        /// </summary>
        [NameInMap("itemList")]
        [Validation(Required=false)]
        public List<GetAccountTransferListResponseBodyItemList> ItemList { get; set; }
        public class GetAccountTransferListResponseBodyItemList : TeaModel {
            /// <summary>
            /// 部门名称
            /// </summary>
            [NameInMap("deptName")]
            [Validation(Required=false)]
            public long? DeptName { get; set; }

            /// <summary>
            /// 员工名称
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

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
