// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class GetTaskQueueResponseBody extends TeaModel {
    @NameInMap("errorCode")
    public String errorCode;

    @NameInMap("errorMsg")
    public String errorMsg;

    @NameInMap("result")
    public GetTaskQueueResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static GetTaskQueueResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetTaskQueueResponseBody self = new GetTaskQueueResponseBody();
        return TeaModel.build(map, self);
    }

    public GetTaskQueueResponseBody setErrorCode(String errorCode) {
        this.errorCode = errorCode;
        return this;
    }
    public String getErrorCode() {
        return this.errorCode;
    }

    public GetTaskQueueResponseBody setErrorMsg(String errorMsg) {
        this.errorMsg = errorMsg;
        return this;
    }
    public String getErrorMsg() {
        return this.errorMsg;
    }

    public GetTaskQueueResponseBody setResult(GetTaskQueueResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetTaskQueueResponseBodyResult getResult() {
        return this.result;
    }

    public GetTaskQueueResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class GetTaskQueueResponseBodyResult extends TeaModel {
        @NameInMap("pendingCount")
        public Integer pendingCount;

        @NameInMap("processingCount")
        public Integer processingCount;

        @NameInMap("totalCount")
        public Integer totalCount;

        public static GetTaskQueueResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetTaskQueueResponseBodyResult self = new GetTaskQueueResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetTaskQueueResponseBodyResult setPendingCount(Integer pendingCount) {
            this.pendingCount = pendingCount;
            return this;
        }
        public Integer getPendingCount() {
            return this.pendingCount;
        }

        public GetTaskQueueResponseBodyResult setProcessingCount(Integer processingCount) {
            this.processingCount = processingCount;
            return this;
        }
        public Integer getProcessingCount() {
            return this.processingCount;
        }

        public GetTaskQueueResponseBodyResult setTotalCount(Integer totalCount) {
            this.totalCount = totalCount;
            return this;
        }
        public Integer getTotalCount() {
            return this.totalCount;
        }

    }

}
