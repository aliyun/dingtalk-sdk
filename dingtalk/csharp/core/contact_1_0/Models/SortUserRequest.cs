// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class SortUserRequest : TeaModel {
        [NameInMap("dingOrgId")]
        [Validation(Required=false)]
        public long? DingOrgId { get; set; }

        /// <summary>
        /// 0 根据姓名拼音升序排列 1 根据姓名拼音降序排列
        /// </summary>
        [NameInMap("sortType")]
        [Validation(Required=false)]
        public int? SortType { get; set; }

        /// <summary>
        /// 用户id列表
        /// </summary>
        [NameInMap("userIdList")]
        [Validation(Required=false)]
        public List<string> UserIdList { get; set; }

    }

}
