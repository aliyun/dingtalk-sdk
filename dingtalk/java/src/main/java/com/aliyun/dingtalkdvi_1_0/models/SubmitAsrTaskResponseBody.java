// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class SubmitAsrTaskResponseBody extends TeaModel {
    @NameInMap("errorCode")
    public String errorCode;

    @NameInMap("errorMsg")
    public String errorMsg;

    @NameInMap("result")
    public SubmitAsrTaskResponseBodyResult result;

    @NameInMap("success")
    public String success;

    public static SubmitAsrTaskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SubmitAsrTaskResponseBody self = new SubmitAsrTaskResponseBody();
        return TeaModel.build(map, self);
    }

    public SubmitAsrTaskResponseBody setErrorCode(String errorCode) {
        this.errorCode = errorCode;
        return this;
    }
    public String getErrorCode() {
        return this.errorCode;
    }

    public SubmitAsrTaskResponseBody setErrorMsg(String errorMsg) {
        this.errorMsg = errorMsg;
        return this;
    }
    public String getErrorMsg() {
        return this.errorMsg;
    }

    public SubmitAsrTaskResponseBody setResult(SubmitAsrTaskResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public SubmitAsrTaskResponseBodyResult getResult() {
        return this.result;
    }

    public SubmitAsrTaskResponseBody setSuccess(String success) {
        this.success = success;
        return this;
    }
    public String getSuccess() {
        return this.success;
    }

    public static class SubmitAsrTaskResponseBodyResult extends TeaModel {
        @NameInMap("taskId")
        public String taskId;

        public static SubmitAsrTaskResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            SubmitAsrTaskResponseBodyResult self = new SubmitAsrTaskResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public SubmitAsrTaskResponseBodyResult setTaskId(String taskId) {
            this.taskId = taskId;
            return this;
        }
        public String getTaskId() {
            return this.taskId;
        }

    }

}
