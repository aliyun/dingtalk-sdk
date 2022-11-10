// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class GetMultipartFileUploadInfosResponseBody extends TeaModel {
    // 分片Header加签上传信息列表
    // 最大size:
    // 	30
    @NameInMap("multipartHeaderSignatureInfos")
    public java.util.List<GetMultipartFileUploadInfosResponseBodyMultipartHeaderSignatureInfos> multipartHeaderSignatureInfos;

    public static GetMultipartFileUploadInfosResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetMultipartFileUploadInfosResponseBody self = new GetMultipartFileUploadInfosResponseBody();
        return TeaModel.build(map, self);
    }

    public GetMultipartFileUploadInfosResponseBody setMultipartHeaderSignatureInfos(java.util.List<GetMultipartFileUploadInfosResponseBodyMultipartHeaderSignatureInfos> multipartHeaderSignatureInfos) {
        this.multipartHeaderSignatureInfos = multipartHeaderSignatureInfos;
        return this;
    }
    public java.util.List<GetMultipartFileUploadInfosResponseBodyMultipartHeaderSignatureInfos> getMultipartHeaderSignatureInfos() {
        return this.multipartHeaderSignatureInfos;
    }

    public static class GetMultipartFileUploadInfosResponseBodyMultipartHeaderSignatureInfosHeaderSignatureInfo extends TeaModel {
        // 过期时间，单位秒
        @NameInMap("expirationSeconds")
        public Integer expirationSeconds;

        // 请求头
        // 最大size:
        // 	20
        @NameInMap("headers")
        public java.util.Map<String, String> headers;

        // 内网URL, 在网络连通的情况下，使用内网URL可加速服务器间上传
        // 最大size:
        // 	10
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
        // 最大size:
        // 	10
        @NameInMap("resourceUrls")
        public java.util.List<String> resourceUrls;

        public static GetMultipartFileUploadInfosResponseBodyMultipartHeaderSignatureInfosHeaderSignatureInfo build(java.util.Map<String, ?> map) throws Exception {
            GetMultipartFileUploadInfosResponseBodyMultipartHeaderSignatureInfosHeaderSignatureInfo self = new GetMultipartFileUploadInfosResponseBodyMultipartHeaderSignatureInfosHeaderSignatureInfo();
            return TeaModel.build(map, self);
        }

        public GetMultipartFileUploadInfosResponseBodyMultipartHeaderSignatureInfosHeaderSignatureInfo setExpirationSeconds(Integer expirationSeconds) {
            this.expirationSeconds = expirationSeconds;
            return this;
        }
        public Integer getExpirationSeconds() {
            return this.expirationSeconds;
        }

        public GetMultipartFileUploadInfosResponseBodyMultipartHeaderSignatureInfosHeaderSignatureInfo setHeaders(java.util.Map<String, String> headers) {
            this.headers = headers;
            return this;
        }
        public java.util.Map<String, String> getHeaders() {
            return this.headers;
        }

        public GetMultipartFileUploadInfosResponseBodyMultipartHeaderSignatureInfosHeaderSignatureInfo setInternalResourceUrls(java.util.List<String> internalResourceUrls) {
            this.internalResourceUrls = internalResourceUrls;
            return this;
        }
        public java.util.List<String> getInternalResourceUrls() {
            return this.internalResourceUrls;
        }

        public GetMultipartFileUploadInfosResponseBodyMultipartHeaderSignatureInfosHeaderSignatureInfo setRegion(String region) {
            this.region = region;
            return this;
        }
        public String getRegion() {
            return this.region;
        }

        public GetMultipartFileUploadInfosResponseBodyMultipartHeaderSignatureInfosHeaderSignatureInfo setResourceUrls(java.util.List<String> resourceUrls) {
            this.resourceUrls = resourceUrls;
            return this;
        }
        public java.util.List<String> getResourceUrls() {
            return this.resourceUrls;
        }

    }

    public static class GetMultipartFileUploadInfosResponseBodyMultipartHeaderSignatureInfos extends TeaModel {
        // header信息
        @NameInMap("headerSignatureInfo")
        public GetMultipartFileUploadInfosResponseBodyMultipartHeaderSignatureInfosHeaderSignatureInfo headerSignatureInfo;

        // 分片number
        @NameInMap("partNumber")
        public Integer partNumber;

        public static GetMultipartFileUploadInfosResponseBodyMultipartHeaderSignatureInfos build(java.util.Map<String, ?> map) throws Exception {
            GetMultipartFileUploadInfosResponseBodyMultipartHeaderSignatureInfos self = new GetMultipartFileUploadInfosResponseBodyMultipartHeaderSignatureInfos();
            return TeaModel.build(map, self);
        }

        public GetMultipartFileUploadInfosResponseBodyMultipartHeaderSignatureInfos setHeaderSignatureInfo(GetMultipartFileUploadInfosResponseBodyMultipartHeaderSignatureInfosHeaderSignatureInfo headerSignatureInfo) {
            this.headerSignatureInfo = headerSignatureInfo;
            return this;
        }
        public GetMultipartFileUploadInfosResponseBodyMultipartHeaderSignatureInfosHeaderSignatureInfo getHeaderSignatureInfo() {
            return this.headerSignatureInfo;
        }

        public GetMultipartFileUploadInfosResponseBodyMultipartHeaderSignatureInfos setPartNumber(Integer partNumber) {
            this.partNumber = partNumber;
            return this;
        }
        public Integer getPartNumber() {
            return this.partNumber;
        }

    }

}
