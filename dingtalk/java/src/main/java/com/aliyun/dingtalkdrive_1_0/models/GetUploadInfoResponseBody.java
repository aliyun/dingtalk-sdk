// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class GetUploadInfoResponseBody extends TeaModel {
    @NameInMap("stsUploadInfo")
    public GetUploadInfoResponseBodyStsUploadInfo stsUploadInfo;

    public static GetUploadInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetUploadInfoResponseBody self = new GetUploadInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetUploadInfoResponseBody setStsUploadInfo(GetUploadInfoResponseBodyStsUploadInfo stsUploadInfo) {
        this.stsUploadInfo = stsUploadInfo;
        return this;
    }
    public GetUploadInfoResponseBodyStsUploadInfo getStsUploadInfo() {
        return this.stsUploadInfo;
    }

    public static class GetUploadInfoResponseBodyStsUploadInfo extends TeaModel {
        // bucket
        @NameInMap("bucket")
        public String bucket;

        // endPoint
        @NameInMap("endPoint")
        public String endPoint;

        // accessKeyId
        @NameInMap("accessKeyId")
        public String accessKeyId;

        // accessKeySecret
        @NameInMap("accessKeySecret")
        public String accessKeySecret;

        // accessToken
        @NameInMap("accessToken")
        public String accessToken;

        // accessTokenExpiration
        @NameInMap("accessTokenExpirationMillis")
        public Long accessTokenExpirationMillis;

        // mediaId
        @NameInMap("mediaId")
        public String mediaId;

        public static GetUploadInfoResponseBodyStsUploadInfo build(java.util.Map<String, ?> map) throws Exception {
            GetUploadInfoResponseBodyStsUploadInfo self = new GetUploadInfoResponseBodyStsUploadInfo();
            return TeaModel.build(map, self);
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

        public GetUploadInfoResponseBodyStsUploadInfo setMediaId(String mediaId) {
            this.mediaId = mediaId;
            return this;
        }
        public String getMediaId() {
            return this.mediaId;
        }

    }

}
