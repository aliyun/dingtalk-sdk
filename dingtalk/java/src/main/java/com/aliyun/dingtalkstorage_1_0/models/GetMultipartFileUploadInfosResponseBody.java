// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class GetMultipartFileUploadInfosResponseBody extends TeaModel {
    /**
     * <p>分片Header加签上传信息列表</p>
     * <p>最大size:</p>
     * <p>	30</p>
     */
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
        /**
         * <p>header信息</p>
         */
        @NameInMap("headerSignatureInfo")
        public GetMultipartFileUploadInfosResponseBodyMultipartHeaderSignatureInfosHeaderSignatureInfo headerSignatureInfo;

        /**
         * <p>分片number</p>
         */
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
