// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontent_1_0.Models
{
    public class GetMediaCerficateResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>378a1a01**********6fa2886313948e</para>
        /// </summary>
        [NameInMap("mediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>STS.NTR**********q8LrHkgS7w97</para>
        /// </summary>
        [NameInMap("ossAccessKeyId")]
        [Validation(Required=false)]
        public string OssAccessKeyId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DFCXzE5r8x9d4kp**********r1N8eUeh5aU7tM9vVcu</para>
        /// </summary>
        [NameInMap("ossAccessKeySecret")]
        [Validation(Required=false)]
        public string OssAccessKeySecret { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>outin-5e342d**********8bfb00163e024c6a</para>
        /// </summary>
        [NameInMap("ossBucketName")]
        [Validation(Required=false)]
        public string OssBucketName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://oss-cn-*******.aliyuncs.com">https://oss-cn-*******.aliyuncs.com</a></para>
        /// </summary>
        [NameInMap("ossEndpoint")]
        [Validation(Required=false)]
        public string OssEndpoint { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3000</para>
        /// </summary>
        [NameInMap("ossExpiration")]
        [Validation(Required=false)]
        public string OssExpiration { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sv/1c<b><b>53-17a</b>*<b>202/1c</b></b>53-17a*****02.mp4</para>
        /// </summary>
        [NameInMap("ossFileName")]
        [Validation(Required=false)]
        public string OssFileName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CAIS0AR1q6Ft5B2yfSjIr5**********+au5c1eJqHIdZ+h/2LKS<em><b><b><b><b><b>oAO8fvvU0m2tY7PsZlrUqFMQZHBaUPJoutc0OoFL4JpfZv8u84YADi5C</b></b></b></b></b></em>28Wf7waf+AUBXGCTm***********lQCZuW//toJV7b9MRcxClZD5dfrl/LRdjr8lo1xGzUPG2KUzSn3b3BkhlsRYe72Rk8vaHxdaAzRDcgVbmqJcSvJ+jC4C8Ys9gG519XtypvopxbbGT8CNZ5z9A9qp9kM49/izc7P6QH35b4RiNL8/Z7tQNXwhiffobHa9YrfHgmNhlvvDSj43t1ytVOeZcX0akQ5u7ku7ZHP+oLt8jaYvjP3PE3rLpMYLu4T48ZXUSODtDYcZDUHhrEk4RUjXdI6Of8UrWSQC7Wsr217otg7Fyyk3s8MaHAkWLX7SB2DwEB4c4aEokVW4RxnezW6UBaRBpbld7Bq6cV5lOdBRZoK+KzQrJTX9Ez2pLmuD6e/LOs7oDVJ37WZtKyuh4Y49d4U8rVEjPQqiykT0pFgpfTK1RzbPmNLKm9baB25/zW+PdDe0dsVgoIFKOpiGWG3RLNn+ztJ9xbkeE+sKUkaGXr8lsTAIl6t4CVFiIIIZnoVY+u/LstBnLqrPoDHnt5XR/uPugptgRuRo8I6372bTJ42WG5Ub9O/dpxJ3lP0R0WgmydnBDx/Sfu2kKvRhpkRvvZEpPtwzIij/gLZZEiazRmyhefo5XmPXFTQmn8l5pAMmy/60xXudvbE2R0EQDY9YCGoABVx6uDvU/Q1kkRe4S00MofmJkOWVwk8jVgBbmlA6LUJQm70f9nksTLYjJ2HVOFHQO8MrnE2ur/xx5jYWpCHI0Aa4sGCjZShV0NNuT8yqNmGOKUReffWW47gxKv5Hhc6j8cAKUMZivrqCCuQaEqhNnKjDH7NS3PsXXyvhNF1KS6uQ=</para>
        /// </summary>
        [NameInMap("ossSecurityToken")]
        [Validation(Required=false)]
        public string OssSecurityToken { get; set; }

    }

}
