// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class QueryPermissionByUserIdResponseBody : TeaModel {
        /// <summary>
        /// 权限信息列表
        /// </summary>
        [NameInMap("permissionDTOList")]
        [Validation(Required=false)]
        public List<QueryPermissionByUserIdResponseBodyPermissionDTOList> PermissionDTOList { get; set; }
        public class QueryPermissionByUserIdResponseBodyPermissionDTOList : TeaModel {
            [NameInMap("actionIdList")]
            [Validation(Required=false)]
            public List<string> ActionIdList { get; set; }

            [NameInMap("resourceIdentity")]
            [Validation(Required=false)]
            public string ResourceIdentity { get; set; }

        }

        /// <summary>
        /// 用户ID
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
