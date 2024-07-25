// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontent_1_0.models;

import com.aliyun.tea.*;

public class DeleteVideosResponseBody extends TeaModel {
    @NameInMap("result")
    public DeleteVideosResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static DeleteVideosResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteVideosResponseBody self = new DeleteVideosResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteVideosResponseBody setResult(DeleteVideosResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public DeleteVideosResponseBodyResult getResult() {
        return this.result;
    }

    public DeleteVideosResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class DeleteVideosResponseBodyResult extends TeaModel {
        @NameInMap("failed")
        public java.util.List<String> failed;

        @NameInMap("success")
        public Long success;

        @NameInMap("total")
        public Long total;

        public static DeleteVideosResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            DeleteVideosResponseBodyResult self = new DeleteVideosResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public DeleteVideosResponseBodyResult setFailed(java.util.List<String> failed) {
            this.failed = failed;
            return this;
        }
        public java.util.List<String> getFailed() {
            return this.failed;
        }

        public DeleteVideosResponseBodyResult setSuccess(Long success) {
            this.success = success;
            return this;
        }
        public Long getSuccess() {
            return this.success;
        }

        public DeleteVideosResponseBodyResult setTotal(Long total) {
            this.total = total;
            return this;
        }
        public Long getTotal() {
            return this.total;
        }

    }

}
