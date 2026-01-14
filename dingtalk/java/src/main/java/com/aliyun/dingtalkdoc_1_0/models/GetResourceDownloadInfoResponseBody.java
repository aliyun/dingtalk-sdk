// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class GetResourceDownloadInfoResponseBody extends TeaModel {
    @NameInMap("result")
    public GetResourceDownloadInfoResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static GetResourceDownloadInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetResourceDownloadInfoResponseBody self = new GetResourceDownloadInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetResourceDownloadInfoResponseBody setResult(GetResourceDownloadInfoResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetResourceDownloadInfoResponseBodyResult getResult() {
        return this.result;
    }

    public GetResourceDownloadInfoResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class GetResourceDownloadInfoResponseBodyResult extends TeaModel {
        @NameInMap("downloadUrl")
        public String downloadUrl;

        @NameInMap("resourceName")
        public String resourceName;

        @NameInMap("size")
        public Long size;

        public static GetResourceDownloadInfoResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetResourceDownloadInfoResponseBodyResult self = new GetResourceDownloadInfoResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetResourceDownloadInfoResponseBodyResult setDownloadUrl(String downloadUrl) {
            this.downloadUrl = downloadUrl;
            return this;
        }
        public String getDownloadUrl() {
            return this.downloadUrl;
        }

        public GetResourceDownloadInfoResponseBodyResult setResourceName(String resourceName) {
            this.resourceName = resourceName;
            return this;
        }
        public String getResourceName() {
            return this.resourceName;
        }

        public GetResourceDownloadInfoResponseBodyResult setSize(Long size) {
            this.size = size;
            return this;
        }
        public Long getSize() {
            return this.size;
        }

    }

}
