// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class ChangeGroupOwnerResponseBody : TeaModel {
        /// <summary>
        /// 群主在业务系统内的唯一标识
        /// </summary>
        [NameInMap("newGroupOwnerId")]
        [Validation(Required=false)]
        public string NewGroupOwnerId { get; set; }

        /// <summary>
        /// 群主类型<2.钉内用户类型 3.钉外用户类型>
        /// </summary>
        [NameInMap("newGroupOwnerType")]
        [Validation(Required=false)]
        public int? NewGroupOwnerType { get; set; }

    }

}
