// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontent_1_0.models;

import com.aliyun.tea.*;

public class GetMediaCerficateResponseBody extends TeaModel {
    // 媒体文件ID
    @NameInMap("mediaId")
    public String mediaId;

    // 上传授权密钥ID
    @NameInMap("ossAccessKeyId")
    public String ossAccessKeyId;

    // 上传授权密钥
    @NameInMap("ossAccessKeySecret")
    public String ossAccessKeySecret;

    // OSS Bucket名称
    @NameInMap("ossBucketName")
    public String ossBucketName;

    // OSS区域地址
    @NameInMap("ossEndpoint")
    public String ossEndpoint;

    // 凭证有效时间(单位秒)，当上传凭证过期时，需要重新使用本次返回的videoId重新调用接口进行凭证刷新
    @NameInMap("ossExpiration")
    public String ossExpiration;

    // 分配的媒体文件名
    @NameInMap("ossFileName")
    public String ossFileName;

    // 上传授权安全令牌
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
