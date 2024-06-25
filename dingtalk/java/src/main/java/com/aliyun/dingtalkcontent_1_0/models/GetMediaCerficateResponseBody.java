// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontent_1_0.models;

import com.aliyun.tea.*;

public class GetMediaCerficateResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>378a1a01**********6fa2886313948e</p>
     */
    @NameInMap("mediaId")
    public String mediaId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>STS.NTR**********q8LrHkgS7w97</p>
     */
    @NameInMap("ossAccessKeyId")
    public String ossAccessKeyId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>DFCXzE5r8x9d4kp**********r1N8eUeh5aU7tM9vVcu</p>
     */
    @NameInMap("ossAccessKeySecret")
    public String ossAccessKeySecret;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>outin-5e342d**********8bfb00163e024c6a</p>
     */
    @NameInMap("ossBucketName")
    public String ossBucketName;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p><a href="https://oss-cn-*******.aliyuncs.com">https://oss-cn-*******.aliyuncs.com</a></p>
     */
    @NameInMap("ossEndpoint")
    public String ossEndpoint;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>3000</p>
     */
    @NameInMap("ossExpiration")
    public String ossExpiration;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>sv/1c<strong><strong>53-17a</strong>*<strong>202/1c</strong></strong>53-17a*****02.mp4</p>
     */
    @NameInMap("ossFileName")
    public String ossFileName;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>CAIS0AR1q6Ft5B2yfSjIr5**********+au5c1eJqHIdZ+h/2LKS<em><strong><strong><strong><strong><strong>oAO8fvvU0m2tY7PsZlrUqFMQZHBaUPJoutc0OoFL4JpfZv8u84YADi5C</strong></strong></strong></strong></strong></em>28Wf7waf+AUBXGCTm***********lQCZuW//toJV7b9MRcxClZD5dfrl/LRdjr8lo1xGzUPG2KUzSn3b3BkhlsRYe72Rk8vaHxdaAzRDcgVbmqJcSvJ+jC4C8Ys9gG519XtypvopxbbGT8CNZ5z9A9qp9kM49/izc7P6QH35b4RiNL8/Z7tQNXwhiffobHa9YrfHgmNhlvvDSj43t1ytVOeZcX0akQ5u7ku7ZHP+oLt8jaYvjP3PE3rLpMYLu4T48ZXUSODtDYcZDUHhrEk4RUjXdI6Of8UrWSQC7Wsr217otg7Fyyk3s8MaHAkWLX7SB2DwEB4c4aEokVW4RxnezW6UBaRBpbld7Bq6cV5lOdBRZoK+KzQrJTX9Ez2pLmuD6e/LOs7oDVJ37WZtKyuh4Y49d4U8rVEjPQqiykT0pFgpfTK1RzbPmNLKm9baB25/zW+PdDe0dsVgoIFKOpiGWG3RLNn+ztJ9xbkeE+sKUkaGXr8lsTAIl6t4CVFiIIIZnoVY+u/LstBnLqrPoDHnt5XR/uPugptgRuRo8I6372bTJ42WG5Ub9O/dpxJ3lP0R0WgmydnBDx/Sfu2kKvRhpkRvvZEpPtwzIij/gLZZEiazRmyhefo5XmPXFTQmn8l5pAMmy/60xXudvbE2R0EQDY9YCGoABVx6uDvU/Q1kkRe4S00MofmJkOWVwk8jVgBbmlA6LUJQm70f9nksTLYjJ2HVOFHQO8MrnE2ur/xx5jYWpCHI0Aa4sGCjZShV0NNuT8yqNmGOKUReffWW47gxKv5Hhc6j8cAKUMZivrqCCuQaEqhNnKjDH7NS3PsXXyvhNF1KS6uQ=</p>
     */
    @NameInMap("ossSecurityToken")
    public String ossSecurityToken;

    public static GetMediaCerficateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetMediaCerficateResponseBody self = new GetMediaCerficateResponseBody();
        return TeaModel.build(map, self);
    }

    public GetMediaCerficateResponseBody setMediaId(String mediaId) {
        this.mediaId = mediaId;
        return this;
    }
    public String getMediaId() {
        return this.mediaId;
    }

    public GetMediaCerficateResponseBody setOssAccessKeyId(String ossAccessKeyId) {
        this.ossAccessKeyId = ossAccessKeyId;
        return this;
    }
    public String getOssAccessKeyId() {
        return this.ossAccessKeyId;
    }

    public GetMediaCerficateResponseBody setOssAccessKeySecret(String ossAccessKeySecret) {
        this.ossAccessKeySecret = ossAccessKeySecret;
        return this;
    }
    public String getOssAccessKeySecret() {
        return this.ossAccessKeySecret;
    }

    public GetMediaCerficateResponseBody setOssBucketName(String ossBucketName) {
        this.ossBucketName = ossBucketName;
        return this;
    }
    public String getOssBucketName() {
        return this.ossBucketName;
    }

    public GetMediaCerficateResponseBody setOssEndpoint(String ossEndpoint) {
        this.ossEndpoint = ossEndpoint;
        return this;
    }
    public String getOssEndpoint() {
        return this.ossEndpoint;
    }

    public GetMediaCerficateResponseBody setOssExpiration(String ossExpiration) {
        this.ossExpiration = ossExpiration;
        return this;
    }
    public String getOssExpiration() {
        return this.ossExpiration;
    }

    public GetMediaCerficateResponseBody setOssFileName(String ossFileName) {
        this.ossFileName = ossFileName;
        return this;
    }
    public String getOssFileName() {
        return this.ossFileName;
    }

    public GetMediaCerficateResponseBody setOssSecurityToken(String ossSecurityToken) {
        this.ossSecurityToken = ossSecurityToken;
        return this;
    }
    public String getOssSecurityToken() {
        return this.ossSecurityToken;
    }

}
