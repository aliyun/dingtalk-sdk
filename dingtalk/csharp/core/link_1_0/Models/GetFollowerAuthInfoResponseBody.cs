// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklink_1_0.Models
{
    public class GetFollowerAuthInfoResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetFollowerAuthInfoResponseBodyResult Result { get; set; }
        public class GetFollowerAuthInfoResponseBodyResult : TeaModel {
            [NameInMap("authInfo")]
            [Validation(Required=false)]
            public GetFollowerAuthInfoResponseBodyResultAuthInfo AuthInfo { get; set; }
            public class GetFollowerAuthInfoResponseBodyResultAuthInfo : TeaModel {
                [NameInMap("mainCorp")]
                [Validation(Required=false)]
                public GetFollowerAuthInfoResponseBodyResultAuthInfoMainCorp MainCorp { get; set; }
                public class GetFollowerAuthInfoResponseBodyResultAuthInfoMainCorp : TeaModel {
                    [NameInMap("authorized")]
                    [Validation(Required=false)]
                    public bool? Authorized { get; set; }

                    [NameInMap("corpName")]
                    [Validation(Required=false)]
                    public string CorpName { get; set; }

                }

                [NameInMap("mobile")]
                [Validation(Required=false)]
                public GetFollowerAuthInfoResponseBodyResultAuthInfoMobile Mobile { get; set; }
                public class GetFollowerAuthInfoResponseBodyResultAuthInfoMobile : TeaModel {
                    [NameInMap("authorized")]
                    [Validation(Required=false)]
                    public bool? Authorized { get; set; }

                    [NameInMap("mobile")]
                    [Validation(Required=false)]
                    public string Mobile { get; set; }

                    [NameInMap("stateCode")]
                    [Validation(Required=false)]
                    public string StateCode { get; set; }

                }

            }

        }

    }

}
