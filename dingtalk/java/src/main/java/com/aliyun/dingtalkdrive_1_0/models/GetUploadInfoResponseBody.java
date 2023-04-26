// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class GetUploadInfoResponseBody extends TeaModel {
    @NameInMap("headerSignatureUploadInfo")
    public GetUploadInfoResponseBodyHeaderSignatureUploadInfo headerSignatureUploadInfo;

    @NameInMap("region")
    public String region;

    @NameInMap("stsUploadInfo")
    public GetUploadInfoResponseBodyStsUploadInfo stsUploadInfo;

    public static GetUploadInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetUploadInfoResponseBody self = new GetUploadInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetUploadInfoResponseBody setHeaderSignatureUploadInfo(GetUploadInfoResponseBodyHeaderSignatureUploadInfo headerSignatureUploadInfo) {
        this.headerSignatureUploadInfo = headerSignatureUploadInfo;
        return this;
    }
    public GetUploadInfoResponseBodyHeaderSignatureUploadInfo getHeaderSignatureUploadInfo() {
        return this.headerSignatureUploadInfo;
    }

    public GetUploadInfoResponseBody setRegion(String region) {
        this.region = region;
        return this;
    }
    public String getRegion() {
        return this.region;
    }

    public GetUploadInfoResponseBody setStsUploadInfo(GetUploadInfoResponseBodyStsUploadInfo stsUploadInfo) {
        this.stsUploadInfo = stsUploadInfo;
        return this;
    }
    public GetUploadInfoResponseBodyStsUploadInfo getStsUploadInfo() {
        return this.stsUploadInfo;
    }

    public static class GetUploadInfoResponseBodyHeaderSignatureUploadInfo extends TeaModel {
        @NameInMap("expirationSeconds")
        public Integer expirationSeconds;

        @NameInMap("headers")
        public java.util.Map<String, ?> headers;

        @NameInMap("internalResourceUrl")
        public String internalResourceUrl;

        @NameInMap("mediaId")
        public String mediaId;

        @NameInMap("resourceUrl")
        public String resourceUrl;

        public static GetUploadInfoResponseBodyHeaderSignatureUploadInfo build(java.util.Map<String, ?> map) throws Exception {
            GetUploadInfoResponseBodyHeaderSignatureUploadInfo self = new GetUploadInfoResponseBodyHeaderSignatureUploadInfo();
            return TeaModel.build(map, self);
        }

        public GetUploadInfoResponseBodyHeaderSignatureUploadInfo setExpirationSeconds(Integer expirationSeconds) {
            this.expirationSeconds = expirationSeconds;
            return this;
        }
        public Integer getExpirationSeconds() {
            return this.expirationSeconds;
        }

        public GetUploadInfoResponseBodyHeaderSignatureUploadInfo setHeaders(java.util.Map<String, ?> headers) {
            this.headers = headers;
            return this;
        }
        public java.util.Map<String, ?> getHeaders() {
            return this.headers;
        }

        public GetUploadInfoResponseBodyHeaderSignatureUploadInfo setInternalResourceUrl(String internalResourceUrl) {
            this.internalResourceUrl = internalResourceUrl;
            return this;
        }
        public String getInternalResourceUrl() {
            return this.internalResourceUrl;
        }

        public GetUploadInfoResponseBodyHeaderSignatureUploadInfo setMediaId(String mediaId) {
            this.mediaId = mediaId;
            return this;
        }
        public String getMediaId() {
            return this.mediaId;
        }

        public GetUploadInfoResponseBodyHeaderSignatureUploadInfo setResourceUrl(String resourceUrl) {
            this.resourceUrl = resourceUrl;
            return this;
        }
        public String getResourceUrl() {
            return this.resourceUrl;
        }

    }

    public static class GetUploadInfoResponseBodyStsUploadInfo extends TeaModel {
        @NameInMap("accessKeyId")
        public String accessKeyId;

        @NameInMap("accessKeySecret")
        public String accessKeySecret;

        @NameInMap("accessToken")
        public String accessToken;

        @NameInMap("accessTokenExpirationMillis")
        public Long accessTokenExpirationMillis;

        @NameInMap("bucket")
        public String bucket;

        @NameInMap("endPoint")
        public String endPoint;

        @NameInMap("internalEndPoint")
        public String internalEndPoint;

        @NameInMap("mediaId")
        public String mediaId;

        public static GetUploadInfoResponseBodyStsUploadInfo build(java.util.Map<String, ?> map) throws Exception {
            GetUploadInfoResponseBodyStsUploadInfo self = new GetUploadInfoResponseBodyStsUploadInfo();
            return TeaModel.build(map, self);
        }

        public GetUploadInfoResponseBodyStsUploadInfo setAccessKeyId(String accessKeyId) {
            this.accessKeyId = accessKeyId;
            return this;
        }
        public String getAccessKeyId() {
            return this.accessKeyId;
        }

        public GetUploadInfoResponseBodyStsUploadInfo setAccessKeySecret(String accessKeySecret) {
            this.accessKeySecret = accessKeySecret;
            return this;
        }
        public String getAccessKeySecret() {
            return this.accessKeySecret;
        }

        public GetUploadInfoResponseBodyStsUploadInfo setAccessToken(String accessToken) {
            this.accessToken = accessToken;
            return this;
        }
        public String getAccessToken() {
            return this.accessToken;
        }

        public GetUploadInfoResponseBodyStsUploadInfo setAccessTokenExpirationMillis(Long accessTokenExpirationMillis) {
            this.accessTokenExpirationMillis = accessTokenExpirationMillis;
            return this;
        }
        public Long getAccessTokenExpirationMillis() {
            return this.accessTokenExpirationMillis;
        }

        public GetUploadInfoResponseBodyStsUploadInfo setBucket(String bucket) {
            this.bucket = bucket;
            return this;
        }
        public String getBucket() {
            return this.bucket;
        }

        public GetUploadInfoResponseBodyStsUploadInfo setEndPoint(String endPoint) {
            this.endPoint = endPoint;
            return this;
        }
        public String getEndPoint() {
            return this.endPoint;
        }

        public GetUploadInfoResponseBodyStsUploadInfo setInternalEndPoint(String internalEndPoint) {
            this.internalEndPoint = internalEndPoint;
            return this;
        }
        public String getInternalEndPoint() {
            return this.internalEndPoint;
        }

        public GetUploadInfoResponseBodyStsUploadInfo setMediaId(String mediaId) {
            this.mediaId = mediaId;
            return this;
        }
        public String getMediaId() {
            return this.mediaId;
        }

    }

}
