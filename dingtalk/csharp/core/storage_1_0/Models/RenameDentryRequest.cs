// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class RenameDentryRequest : TeaModel {
        /// <summary>
        /// 名称, 规则：
        /// 1. 头尾不能包含空格，否则会自动去除
        /// 2. 不能包含特殊字符，包括：制表符、*、"、<、>、|
        /// 3. 不能以"."结尾
        /// </summary>
        [NameInMap("newName")]
        [Validation(Required=false)]
        public string NewName { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
