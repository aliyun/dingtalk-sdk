// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class GetFileDownloadInfoResponseBody extends TeaModel {
    @NameInMap("headerSignatureInfo")
    public GetFileDownloadInfoResponseBodyHeaderSignatureInfo headerSignatureInfo;

    /**
     * <strong>example:</strong>
     * <p>HEADER_SIGNATURE</p>
     */
    @NameInMap("protocol")
    public String protocol;

    public static GetFileDownloadInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetFileDownloadInfoResponseBody self = new GetFileDownloadInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetFileDownloadInfoResponseBody setHeaderSignatureInfo(GetFileDownloadInfoResponseBodyHeaderSignatureInfo headerSignatureInfo) {
        this.headerSignatureInfo = headerSignatureInfo;
        return this;
    }
    public GetFileDownloadInfoResponseBodyHeaderSignatureInfo getHeaderSignatureInfo() {
        return this.headerSignatureInfo;
    }

    public GetFileDownloadInfoResponseBody setProtocol(String protocol) {
        this.protocol = protocol;
        return this;
    }
    public String getProtocol() {
        return this.protocol;
    }

    public static class GetFileDownloadInfoResponseBodyHeaderSignatureInfo extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>900</p>
         */
        @NameInMap("expirationSeconds")
        public Integer expirationSeconds;

        @NameInMap("headers")
        public java.util.Map<String, String> headers;

        @NameInMap("internalResourceUrls")
        public java.util.List<String> internalResourceUrls;

        /**
         * <strong>example:</strong>
         * <p>ZHANGJIAKOU</p>
         */
        @NameInMap("region")
        public String region;

        @NameInMap("resourceUrls")
        public java.util.List<String> resourceUrls;

        public static GetFileDownloadInfoResponseBodyHeaderSignatureInfo build(java.util.Map<String, ?> map) throws Exception {
            GetFileDownloadInfoResponseBodyHeaderSignatureInfo self = new GetFileDownloadInfoResponseBodyHeaderSignatureInfo();
            return TeaModel.build(map, self);
        }

        public GetFileDownloadInfoResponseBodyHeaderSignatureInfo setExpirationSeconds(Integer expirationSeconds) {
            this.expirationSeconds = expirationSeconds;
            return this;
        }
        public Integer getExpirationSeconds() {
            return this.expirationSeconds;
        }

        public GetFileDownloadInfoResponseBodyHeaderSignatureInfo setHeaders(java.util.Map<String, String> headers) {
            this.headers = headers;
            return this;
        }
        public java.util.Map<String, String> getHeaders() {
            return this.headers;
        }

        public GetFileDownloadInfoResponseBodyHeaderSignatureInfo setInternalResourceUrls(java.util.List<String> internalResourceUrls) {
            this.internalResourceUrls = internalResourceUrls;
            return this;
        }
        public java.util.List<String> getInternalResourceUrls() {
            return this.internalResourceUrls;
        }

        public GetFileDownloadInfoResponseBodyHeaderSignatureInfo setRegion(String region) {
            this.region = region;
            return this;
        }
        public String getRegion() {
            return this.region;
        }

        public GetFileDownloadInfoResponseBodyHeaderSignatureInfo setResourceUrls(java.util.List<String> resourceUrls) {
            this.resourceUrls = resourceUrls;
            return this;
        }
        public java.util.List<String> getResourceUrls() {
            return this.resourceUrls;
        }

    }

}
