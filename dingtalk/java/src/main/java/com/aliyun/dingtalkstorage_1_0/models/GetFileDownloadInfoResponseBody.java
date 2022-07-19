// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class GetFileDownloadInfoResponseBody extends TeaModel {
    // Header加签信息, 当protocol等于HEADER_SIGNATURE时，此字段生效
    @NameInMap("headerSignatureInfo")
    public GetFileDownloadInfoResponseBodyHeaderSignatureInfo headerSignatureInfo;

    // 文件下载协议
    // 枚举值:
    // 	HEADER_SIGNATURE: Header加签
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
        // 过期时间，单位秒
        @NameInMap("expirationSeconds")
        public Integer expirationSeconds;

        // 请求头
        @NameInMap("headers")
        public java.util.Map<String, String> headers;

        // 内网URL, 在网络连通的情况下，使用内网URL可加速服务器间上传
        @NameInMap("internalResourceUrls")
        public java.util.List<String> internalResourceUrls;

        // 地域
        // 枚举值:
        // 	ZHANGJIAKOU: 张家口
        // 	SHENZHEN: 深圳
        // 	SHANGHAI: 上海
        // 	SINGAPORE: 新加坡
        // 	UNKNOWN: 未知
        @NameInMap("region")
        public String region;

        // 多个上传下载URL, 前面url优先
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
