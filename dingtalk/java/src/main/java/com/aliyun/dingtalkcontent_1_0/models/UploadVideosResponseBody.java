// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontent_1_0.models;

import com.aliyun.tea.*;

public class UploadVideosResponseBody extends TeaModel {
    @NameInMap("result")
    public UploadVideosResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static UploadVideosResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UploadVideosResponseBody self = new UploadVideosResponseBody();
        return TeaModel.build(map, self);
    }

    public UploadVideosResponseBody setResult(UploadVideosResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public UploadVideosResponseBodyResult getResult() {
        return this.result;
    }

    public UploadVideosResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class UploadVideosResponseBodyResult extends TeaModel {
        @NameInMap("failed")
        public java.util.List<String> failed;

        @NameInMap("hasUploaded")
        public Long hasUploaded;

        @NameInMap("success")
        public Long success;

        @NameInMap("total")
        public Long total;

        public static UploadVideosResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            UploadVideosResponseBodyResult self = new UploadVideosResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public UploadVideosResponseBodyResult setFailed(java.util.List<String> failed) {
            this.failed = failed;
            return this;
        }
        public java.util.List<String> getFailed() {
            return this.failed;
        }

        public UploadVideosResponseBodyResult setHasUploaded(Long hasUploaded) {
            this.hasUploaded = hasUploaded;
            return this;
        }
        public Long getHasUploaded() {
            return this.hasUploaded;
        }

        public UploadVideosResponseBodyResult setSuccess(Long success) {
            this.success = success;
            return this;
        }
        public Long getSuccess() {
            return this.success;
        }

        public UploadVideosResponseBodyResult setTotal(Long total) {
            this.total = total;
            return this;
        }
        public Long getTotal() {
            return this.total;
        }

    }

}
