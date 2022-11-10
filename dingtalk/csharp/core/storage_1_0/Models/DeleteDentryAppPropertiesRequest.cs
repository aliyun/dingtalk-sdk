// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class DeleteDentryAppPropertiesRequest : TeaModel {
        /// <summary>
        /// 文件上App属性名称
        /// 最大size:
        /// 	3
        /// </summary>
        [NameInMap("propertyNames")]
        [Validation(Required=false)]
        public List<string> PropertyNames { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
