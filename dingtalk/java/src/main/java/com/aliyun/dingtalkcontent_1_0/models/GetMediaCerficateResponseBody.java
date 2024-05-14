// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontent_1_0.models;

import com.aliyun.tea.*;

public class GetMediaCerficateResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("mediaId")
    public String mediaId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("ossAccessKeyId")
    public String ossAccessKeyId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("ossAccessKeySecret")
    public String ossAccessKeySecret;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("ossBucketName")
    public String ossBucketName;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("ossEndpoint")
    public String ossEndpoint;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("ossExpiration")
    public String ossExpiration;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("ossFileName")
    public String ossFileName;

    /**
     * <p>This parameter is required.</p>
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
