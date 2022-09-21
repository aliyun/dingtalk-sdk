// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklink_1_0.Models
{
    public class GetFollowerAuthInfoResponseBody : TeaModel {
        /// <summary>
        /// 响应结果
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetFollowerAuthInfoResponseBodyResult Result { get; set; }
        public class GetFollowerAuthInfoResponseBodyResult : TeaModel {
            /// <summary>
            /// 授权详情
            /// </summary>
            [NameInMap("authInfo")]
            [Validation(Required=false)]
            public GetFollowerAuthInfoResponseBodyResultAuthInfo AuthInfo { get; set; }
            public class GetFollowerAuthInfoResponseBodyResultAuthInfo : TeaModel {
                /// <summary>
                /// 用户主组织信息
                /// 需要用户授权给应用后返回此信息。
                /// </summary>
                [NameInMap("mainCorp")]
                [Validation(Required=false)]
                public GetFollowerAuthInfoResponseBodyResultAuthInfoMainCorp MainCorp { get; set; }
                public class GetFollowerAuthInfoResponseBodyResultAuthInfoMainCorp : TeaModel {
                    /// <summary>
                    /// 是否授权主组织信息。
                    /// 当且仅当此值为true时返回用户主组织信息。
                    /// </summary>
                    [NameInMap("authorized")]
                    [Validation(Required=false)]
                    public bool? Authorized { get; set; }

                    /// <summary>
                    /// 主组织名
                    /// </summary>
                    [NameInMap("corpName")]
                    [Validation(Required=false)]
                    public string CorpName { get; set; }

                }

                /// <summary>
                /// 手机号码授权详情。
                /// 需要用户授权给应用后返回此信息。
                /// </summary>
                [NameInMap("mobile")]
                [Validation(Required=false)]
                public GetFollowerAuthInfoResponseBodyResultAuthInfoMobile Mobile { get; set; }
                public class GetFollowerAuthInfoResponseBodyResultAuthInfoMobile : TeaModel {
                    /// <summary>
                    /// 用户是否授权手机号码信息。
                    /// 当且仅当此值为true时返回手机号码信息。
                    /// </summary>
                    [NameInMap("authorized")]
                    [Validation(Required=false)]
                    public bool? Authorized { get; set; }

                    /// <summary>
                    /// 手机号码
                    /// </summary>
                    [NameInMap("mobile")]
                    [Validation(Required=false)]
                    public string Mobile { get; set; }

                    /// <summary>
                    /// 地区码
                    /// </summary>
                    [NameInMap("stateCode")]
                    [Validation(Required=false)]
                    public string StateCode { get; set; }

                }

            }

        }

    }

}
