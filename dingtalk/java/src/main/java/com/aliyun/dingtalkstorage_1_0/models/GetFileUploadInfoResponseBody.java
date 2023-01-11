// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class GetFileUploadInfoResponseBody extends TeaModel {
    /**
     * <p>Header加签上传信息, 当protocol等于HEADER_SIGNATURE时，此字段生效</p>
     */
    @NameInMap("headerSignatureInfo")
    public GetFileUploadInfoResponseBodyHeaderSignatureInfo headerSignatureInfo;

    /**
     * <p>上传协议，根据不同上传类型返回对应的信息.</p>
     * <p>枚举值:</p>
     * <p>	HEADER_SIGNATURE: Header加签</p>
     */
    @NameInMap("protocol")
    public String protocol;

    /**
     * <p>文件存储类型</p>
     * <p>枚举值:</p>
     * <p>	DINGTALK: 钉钉统一存储驱动</p>
     * <p>	ALIDOC: 钉钉文档存储驱动</p>
     * <p>	SHANJI: 闪记存储驱动</p>
     * <p>	UNKNOWN: 未知驱动</p>
     */
    @NameInMap("storageDriver")
    public String storageDriver;

    /**
     * <p>上传唯一标识</p>
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
         * <p>过期时间，单位秒</p>
         */
        @NameInMap("expirationSeconds")
        public Integer expirationSeconds;

        /**
         * <p>请求头</p>
         * <p>最大size:</p>
         * <p>	20</p>
         */
        @NameInMap("headers")
        public java.util.Map<String, String> headers;

        /**
         * <p>内网URL, 在网络连通的情况下，使用内网URL可加速服务器间上传</p>
         * <p>最大size:</p>
         * <p>	10</p>
         */
        @NameInMap("internalResourceUrls")
        public java.util.List<String> internalResourceUrls;

        /**
         * <p>地域</p>
         * <p>枚举值:</p>
         * <p>	ZHANGJIAKOU: 张家口</p>
         * <p>	SHENZHEN: 深圳</p>
         * <p>	SHANGHAI: 上海</p>
         * <p>	SINGAPORE: 新加坡</p>
         * <p>	UNKNOWN: 未知</p>
         */
        @NameInMap("region")
        public String region;

        /**
         * <p>多个上传下载URL, 前面url优先</p>
         * <p>最大size:</p>
         * <p>	10</p>
         */
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
