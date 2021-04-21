// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class GetDownloadInfoResponseBody extends TeaModel {
    // 下载加签url信息
    @NameInMap("downloadInfo")
    public GetDownloadInfoResponseBodyDownloadInfo downloadInfo;

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

    public static class GetDownloadInfoResponseBodyDownloadInfo extends TeaModel {
        // 加签url
        @NameInMap("resourceUrl")
        public String resourceUrl;

        // 加签url过期时间
        @NameInMap("expirationSeconds")
        public Integer expirationSeconds;

        // headers
        @NameInMap("headers")
        public java.util.Map<String, ?> headers;

        public static GetDownloadInfoResponseBodyDownloadInfo build(java.util.Map<String, ?> map) throws Exception {
            GetDownloadInfoResponseBodyDownloadInfo self = new GetDownloadInfoResponseBodyDownloadInfo();
            return TeaModel.build(map, self);
        }

        public GetDownloadInfoResponseBodyDownloadInfo setResourceUrl(String resourceUrl) {
            this.resourceUrl = resourceUrl;
            return this;
        }
        public String getResourceUrl() {
            return this.resourceUrl;
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

    }

}
