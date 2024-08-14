// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_2_0.Models
{
    public class SetPermissionShareScopeRequest : TeaModel {
        [NameInMap("option")]
        [Validation(Required=false)]
        public SetPermissionShareScopeRequestOption Option { get; set; }
        public class SetPermissionShareScopeRequestOption : TeaModel {
            [NameInMap("canSearch")]
            [Validation(Required=false)]
            public bool? CanSearch { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
