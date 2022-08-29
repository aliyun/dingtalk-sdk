// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class DentryAppPropertiesValue : TeaModel {
        /// <summary>
        /// 属性名称 该属性名称在当前app下需要保证唯一，不同app间同名属性互不影响
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 属性值
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

        /// <summary>
        /// 属性可见范围
        /// 枚举值:
        /// 	PUBLIC: 该属性所有App可见
        /// 	PRIVATE: 该属性仅其归属App可见
        /// </summary>
        [NameInMap("visibility")]
        [Validation(Required=false)]
        public string Visibility { get; set; }

    }

}
