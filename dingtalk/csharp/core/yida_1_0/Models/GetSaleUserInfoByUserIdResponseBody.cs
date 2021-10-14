// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class GetSaleUserInfoByUserIdResponseBody : TeaModel {
        /// <summary>
        /// accountId
        /// </summary>
        [NameInMap("accountId")]
        [Validation(Required=false)]
        public long? AccountId { get; set; }

        /// <summary>
        /// corpList
        /// </summary>
        [NameInMap("corpList")]
        [Validation(Required=false)]
        public List<GetSaleUserInfoByUserIdResponseBodyCorpList> CorpList { get; set; }
        public class GetSaleUserInfoByUserIdResponseBodyCorpList : TeaModel {
            /// <summary>
            /// namespace
            /// </summary>
            [NameInMap("namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// corpId
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// corpName
            /// </summary>
            [NameInMap("corpName")]
            [Validation(Required=false)]
            public string CorpName { get; set; }

        }

        /// <summary>
        /// userId
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// userName
        /// </summary>
        [NameInMap("userName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
