// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class GetResourceUploadInfoResponseBody extends TeaModel {
    @NameInMap("result")
    public GetResourceUploadInfoResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static GetResourceUploadInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetResourceUploadInfoResponseBody self = new GetResourceUploadInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetResourceUploadInfoResponseBody setResult(GetResourceUploadInfoResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetResourceUploadInfoResponseBodyResult getResult() {
        return this.result;
    }

    public GetResourceUploadInfoResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class GetResourceUploadInfoResponseBodyResult extends TeaModel {
        @NameInMap("resourceId")
        public String resourceId;

        @NameInMap("resourceUrl")
        public String resourceUrl;

        @NameInMap("uploadUrl")
        public String uploadUrl;

        public static GetResourceUploadInfoResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetResourceUploadInfoResponseBodyResult self = new GetResourceUploadInfoResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetResourceUploadInfoResponseBodyResult setResourceId(String resourceId) {
            this.resourceId = resourceId;
            return this;
        }
        public String getResourceId() {
            return this.resourceId;
        }

        public GetResourceUploadInfoResponseBodyResult setResourceUrl(String resourceUrl) {
            this.resourceUrl = resourceUrl;
            return this;
        }
        public String getResourceUrl() {
            return this.resourceUrl;
        }

        public GetResourceUploadInfoResponseBodyResult setUploadUrl(String uploadUrl) {
            this.uploadUrl = uploadUrl;
            return this;
        }
        public String getUploadUrl() {
            return this.uploadUrl;
        }

    }

}
