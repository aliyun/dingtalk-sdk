// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksns_storage_1_0.models;

import com.aliyun.tea.*;

public class GetFileDownloadInfoResponseBody extends TeaModel {
    /**
     * <p>Header加签信息, 当protocol等于HEADER_SIGNATURE时，此字段生效</p>
     */
    @NameInMap("headerSignatureInfo")
    public GetFileDownloadInfoResponseBodyHeaderSignatureInfo headerSignatureInfo;

    /**
     * <p>文件下载协议</p>
     * <p>枚举值:</p>
     * <p>	HEADER_SIGNATURE: Header加签</p>
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
