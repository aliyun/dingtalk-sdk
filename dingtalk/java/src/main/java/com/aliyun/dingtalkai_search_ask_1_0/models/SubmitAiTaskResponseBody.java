// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_search_ask_1_0.models;

import com.aliyun.tea.*;

public class SubmitAiTaskResponseBody extends TeaModel {
    @NameInMap("errorCode")
    public String errorCode;

    @NameInMap("errorMsg")
    public String errorMsg;

    @NameInMap("result")
    public SubmitAiTaskResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static SubmitAiTaskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SubmitAiTaskResponseBody self = new SubmitAiTaskResponseBody();
        return TeaModel.build(map, self);
    }

    public SubmitAiTaskResponseBody setErrorCode(String errorCode) {
        this.errorCode = errorCode;
        return this;
    }
    public String getErrorCode() {
        return this.errorCode;
    }

    public SubmitAiTaskResponseBody setErrorMsg(String errorMsg) {
        this.errorMsg = errorMsg;
        return this;
    }
    public String getErrorMsg() {
        return this.errorMsg;
    }

    public SubmitAiTaskResponseBody setResult(SubmitAiTaskResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public SubmitAiTaskResponseBodyResult getResult() {
        return this.result;
    }

    public SubmitAiTaskResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class SubmitAiTaskResponseBodyResult extends TeaModel {
        @NameInMap("taskId")
        public String taskId;

        public static SubmitAiTaskResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            SubmitAiTaskResponseBodyResult self = new SubmitAiTaskResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public SubmitAiTaskResponseBodyResult setTaskId(String taskId) {
            this.taskId = taskId;
            return this;
        }
        public String getTaskId() {
            return this.taskId;
        }

    }

}
