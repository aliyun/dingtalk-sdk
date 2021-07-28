// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class GetFileUploadInfoResponseBody extends TeaModel {
    // OSS上传所需信息：bucket
    @NameInMap("bucket")
    public String bucket;

    // OSS上传所需信息：endPoint
    @NameInMap("endPoint")
    public String endPoint;

    // OSS上传所需信息：accessKeyId
    @NameInMap("accessKeyId")
    public String accessKeyId;

    // OSS上传所需信息：accessKeySecret
    @NameInMap("accessKeySecret")
    public String accessKeySecret;

    // OSS上传所需信息：accessToken
    @NameInMap("accessToken")
    public String accessToken;

    // accessToken有效期截止时间（单位：毫秒），需要在此时间之前完成文件上传
    @NameInMap("accessTokenExpirationMillis")
    public Long accessTokenExpirationMillis;

    // 文件mediaId
    @NameInMap("mediaId")
    public String mediaId;

    public static GetFileUploadInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetFileUploadInfoResponseBody self = new GetFileUploadInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetFileUploadInfoResponseBody setBucket(String bucket) {
        this.bucket = bucket;
        return this;
    }
    public String getBucket() {
        return this.bucket;
    }

    public GetFileUploadInfoResponseBody setEndPoint(String endPoint) {
        this.endPoint = endPoint;
        return this;
    }
    public String getEndPoint() {
        return this.endPoint;
    }

    public GetFileUploadInfoResponseBody setAccessKeyId(String accessKeyId) {
        this.accessKeyId = accessKeyId;
        return this;
    }
    public String getAccessKeyId() {
        return this.accessKeyId;
    }

    public GetFileUploadInfoResponseBody setAccessKeySecret(String accessKeySecret) {
        this.accessKeySecret = accessKeySecret;
        return this;
    }
    public String getAccessKeySecret() {
        return this.accessKeySecret;
    }

    public GetFileUploadInfoResponseBody setAccessToken(String accessToken) {
        this.accessToken = accessToken;
        return this;
    }
    public String getAccessToken() {
        return this.accessToken;
    }

    public GetFileUploadInfoResponseBody setAccessTokenExpirationMillis(Long accessTokenExpirationMillis) {
        this.accessTokenExpirationMillis = accessTokenExpirationMillis;
        return this;
    }
    public Long getAccessTokenExpirationMillis() {
        return this.accessTokenExpirationMillis;
    }

    public GetFileUploadInfoResponseBody setMediaId(String mediaId) {
        this.mediaId = mediaId;
        return this;
    }
    public String getMediaId() {
        return this.mediaId;
    }

}
