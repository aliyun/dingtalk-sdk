// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class AISaleTaskResultResponseBody extends TeaModel {
    @NameInMap("errorCode")
    public String errorCode;

    @NameInMap("errorMsg")
    public String errorMsg;

    @NameInMap("result")
    public AISaleTaskResultResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static AISaleTaskResultResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AISaleTaskResultResponseBody self = new AISaleTaskResultResponseBody();
        return TeaModel.build(map, self);
    }

    public AISaleTaskResultResponseBody setErrorCode(String errorCode) {
        this.errorCode = errorCode;
        return this;
    }
    public String getErrorCode() {
        return this.errorCode;
    }

    public AISaleTaskResultResponseBody setErrorMsg(String errorMsg) {
        this.errorMsg = errorMsg;
        return this;
    }
    public String getErrorMsg() {
        return this.errorMsg;
    }

    public AISaleTaskResultResponseBody setResult(AISaleTaskResultResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public AISaleTaskResultResponseBodyResult getResult() {
        return this.result;
    }

    public AISaleTaskResultResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class AISaleTaskResultResponseBodyResult extends TeaModel {
        @NameInMap("taskResult")
        public String taskResult;

        @NameInMap("taskStatus")
        public Integer taskStatus;

        public static AISaleTaskResultResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            AISaleTaskResultResponseBodyResult self = new AISaleTaskResultResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public AISaleTaskResultResponseBodyResult setTaskResult(String taskResult) {
            this.taskResult = taskResult;
            return this;
        }
        public String getTaskResult() {
            return this.taskResult;
        }

        public AISaleTaskResultResponseBodyResult setTaskStatus(Integer taskStatus) {
            this.taskStatus = taskStatus;
            return this;
        }
        public Integer getTaskStatus() {
            return this.taskStatus;
        }

    }

}
