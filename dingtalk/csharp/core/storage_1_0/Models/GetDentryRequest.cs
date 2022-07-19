// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class GetDentryRequest : TeaModel {
        /// <summary>
        /// 可选参数
        /// </summary>
        [NameInMap("option")]
        [Validation(Required=false)]
        public GetDentryRequestOption Option { get; set; }
        public class GetDentryRequestOption : TeaModel {
            [NameInMap("appIdsForAppProperties")]
            [Validation(Required=false)]
            public List<string> AppIdsForAppProperties { get; set; }
        };

        /// <summary>
        /// 用户id
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
