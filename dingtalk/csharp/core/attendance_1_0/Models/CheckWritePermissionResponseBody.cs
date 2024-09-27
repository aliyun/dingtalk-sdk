// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class CheckWritePermissionResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("entityPermissionMap")]
        [Validation(Required=false)]
        public Dictionary<string, bool?> EntityPermissionMap { get; set; }

    }

}
