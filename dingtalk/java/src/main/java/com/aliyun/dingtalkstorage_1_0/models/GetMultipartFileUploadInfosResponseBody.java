// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class GetMultipartFileUploadInfosResponseBody extends TeaModel {
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
        @NameInMap("expirationSeconds")
        public Integer expirationSeconds;

        @NameInMap("headers")
        public java.util.Map<String, String> headers;

        @NameInMap("internalResourceUrls")
        public java.util.List<String> internalResourceUrls;

        @NameInMap("region")
        public String region;

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
        @NameInMap("headerSignatureInfo")
        public GetMultipartFileUploadInfosResponseBodyMultipartHeaderSignatureInfosHeaderSignatureInfo headerSignatureInfo;

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
