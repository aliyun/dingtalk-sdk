// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class GetFileUploadInfoResponseBody extends TeaModel {
    // Header加签上传信息, 当protocol等于HEADER_SIGNATURE时，此字段生效
    @NameInMap("headerSignatureInfo")
    public GetFileUploadInfoResponseBodyHeaderSignatureInfo headerSignatureInfo;

    // 上传协议，根据不同上传类型返回对应的信息.
    // 枚举值:
    // 	HEADER_SIGNATURE: Header加签
    @NameInMap("protocol")
    public String protocol;

    // 文件存储类型
    // 枚举值:
    // 	DINGTALK: 钉钉统一存储驱动
    // 	ALIDOC: 钉钉文档存储驱动
    // 	UNKNOWN: 未知驱动
    @NameInMap("storageDriver")
    public String storageDriver;

    // 上传唯一标识
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
