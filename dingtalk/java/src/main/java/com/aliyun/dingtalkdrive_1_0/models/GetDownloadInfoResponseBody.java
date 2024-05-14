// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class GetDownloadInfoResponseBody extends TeaModel {
    @NameInMap("downloadInfo")
    public GetDownloadInfoResponseBodyDownloadInfo downloadInfo;

    @NameInMap("region")
    public String region;

    public static GetDownloadInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetDownloadInfoResponseBody self = new GetDownloadInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetDownloadInfoResponseBody setDownloadInfo(GetDownloadInfoResponseBodyDownloadInfo downloadInfo) {
        this.downloadInfo = downloadInfo;
        return this;
    }
    public GetDownloadInfoResponseBodyDownloadInfo getDownloadInfo() {
        return this.downloadInfo;
    }

    public GetDownloadInfoResponseBody setRegion(String region) {
        this.region = region;
        return this;
    }
    public String getRegion() {
        return this.region;
    }

    public static class GetDownloadInfoResponseBodyDownloadInfo extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("expirationSeconds")
        public Integer expirationSeconds;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("headers")
        public java.util.Map<String, ?> headers;

        @NameInMap("internalResourceUrl")
        public String internalResourceUrl;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("resourceUrl")
        public String resourceUrl;

        public static GetDownloadInfoResponseBodyDownloadInfo build(java.util.Map<String, ?> map) throws Exception {
            GetDownloadInfoResponseBodyDownloadInfo self = new GetDownloadInfoResponseBodyDownloadInfo();
            return TeaModel.build(map, self);
        }

        public GetDownloadInfoResponseBodyDownloadInfo setExpirationSeconds(Integer expirationSeconds) {
            this.expirationSeconds = expirationSeconds;
            return this;
        }
        public Integer getExpirationSeconds() {
            return this.expirationSeconds;
        }

        public GetDownloadInfoResponseBodyDownloadInfo setHeaders(java.util.Map<String, ?> headers) {
            this.headers = headers;
            return this;
        }
        public java.util.Map<String, ?> getHeaders() {
            return this.headers;
        }

        public GetDownloadInfoResponseBodyDownloadInfo setInternalResourceUrl(String internalResourceUrl) {
            this.internalResourceUrl = internalResourceUrl;
            return this;
        }
        public String getInternalResourceUrl() {
            return this.internalResourceUrl;
        }

        public GetDownloadInfoResponseBodyDownloadInfo setResourceUrl(String resourceUrl) {
            this.resourceUrl = resourceUrl;
            return this;
        }
        public String getResourceUrl() {
            return this.resourceUrl;
        }

    }

}
