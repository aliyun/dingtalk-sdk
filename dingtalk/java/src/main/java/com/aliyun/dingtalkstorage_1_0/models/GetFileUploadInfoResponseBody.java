// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class GetFileUploadInfoResponseBody extends TeaModel {
    @NameInMap("headerSignatureInfo")
    public GetFileUploadInfoResponseBodyHeaderSignatureInfo headerSignatureInfo;

    /**
     * <strong>example:</strong>
     * <p>HEADER_SIGNATURE</p>
     */
    @NameInMap("protocol")
    public String protocol;

    /**
     * <strong>example:</strong>
     * <p>DINGTALK</p>
     */
    @NameInMap("storageDriver")
    public String storageDriver;

    /**
     * <strong>example:</strong>
     * <p>upload_key</p>
     */
    @NameInMap("uploadKey")
    public String uploadKey;

    public static GetFileUploadInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetFileUploadInfoResponseBody self = new GetFileUploadInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetFileUploadInfoResponseBody setHeaderSignatureInfo(GetFileUploadInfoResponseBodyHeaderSignatureInfo headerSignatureInfo) {
        this.headerSignatureInfo = headerSignatureInfo;
        return this;
    }
    public GetFileUploadInfoResponseBodyHeaderSignatureInfo getHeaderSignatureInfo() {
        return this.headerSignatureInfo;
    }

    public GetFileUploadInfoResponseBody setProtocol(String protocol) {
        this.protocol = protocol;
        return this;
    }
    public String getProtocol() {
        return this.protocol;
    }

    public GetFileUploadInfoResponseBody setStorageDriver(String storageDriver) {
        this.storageDriver = storageDriver;
        return this;
    }
    public String getStorageDriver() {
        return this.storageDriver;
    }

    public GetFileUploadInfoResponseBody setUploadKey(String uploadKey) {
        this.uploadKey = uploadKey;
        return this;
    }
    public String getUploadKey() {
        return this.uploadKey;
    }

    public static class GetFileUploadInfoResponseBodyHeaderSignatureInfo extends TeaModel {
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

        public static GetFileUploadInfoResponseBodyHeaderSignatureInfo build(java.util.Map<String, ?> map) throws Exception {
            GetFileUploadInfoResponseBodyHeaderSignatureInfo self = new GetFileUploadInfoResponseBodyHeaderSignatureInfo();
            return TeaModel.build(map, self);
        }

        public GetFileUploadInfoResponseBodyHeaderSignatureInfo setExpirationSeconds(Integer expirationSeconds) {
            this.expirationSeconds = expirationSeconds;
            return this;
        }
        public Integer getExpirationSeconds() {
            return this.expirationSeconds;
        }

        public GetFileUploadInfoResponseBodyHeaderSignatureInfo setHeaders(java.util.Map<String, String> headers) {
            this.headers = headers;
            return this;
        }
        public java.util.Map<String, String> getHeaders() {
            return this.headers;
        }

        public GetFileUploadInfoResponseBodyHeaderSignatureInfo setInternalResourceUrls(java.util.List<String> internalResourceUrls) {
            this.internalResourceUrls = internalResourceUrls;
            return this;
        }
        public java.util.List<String> getInternalResourceUrls() {
            return this.internalResourceUrls;
        }

        public GetFileUploadInfoResponseBodyHeaderSignatureInfo setRegion(String region) {
            this.region = region;
            return this;
        }
        public String getRegion() {
            return this.region;
        }

        public GetFileUploadInfoResponseBodyHeaderSignatureInfo setResourceUrls(java.util.List<String> resourceUrls) {
            this.resourceUrls = resourceUrls;
            return this;
        }
        public java.util.List<String> getResourceUrls() {
            return this.resourceUrls;
        }

    }

}
