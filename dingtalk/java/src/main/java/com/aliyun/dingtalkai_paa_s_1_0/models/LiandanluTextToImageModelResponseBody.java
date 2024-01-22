// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_paa_s_1_0.models;

import com.aliyun.tea.*;

public class LiandanluTextToImageModelResponseBody extends TeaModel {
    @NameInMap("result")
    public LiandanluTextToImageModelResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static LiandanluTextToImageModelResponseBody build(java.util.Map<String, ?> map) throws Exception {
        LiandanluTextToImageModelResponseBody self = new LiandanluTextToImageModelResponseBody();
        return TeaModel.build(map, self);
    }

    public LiandanluTextToImageModelResponseBody setResult(LiandanluTextToImageModelResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public LiandanluTextToImageModelResponseBodyResult getResult() {
        return this.result;
    }

    public LiandanluTextToImageModelResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class LiandanluTextToImageModelResponseBodyResult extends TeaModel {
        @NameInMap("requestId")
        public String requestId;

        @NameInMap("taskId")
        public String taskId;

        @NameInMap("taskStatus")
        public String taskStatus;

        public static LiandanluTextToImageModelResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            LiandanluTextToImageModelResponseBodyResult self = new LiandanluTextToImageModelResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public LiandanluTextToImageModelResponseBodyResult setRequestId(String requestId) {
            this.requestId = requestId;
            return this;
        }
        public String getRequestId() {
            return this.requestId;
        }

        public LiandanluTextToImageModelResponseBodyResult setTaskId(String taskId) {
            this.taskId = taskId;
            return this;
        }
        public String getTaskId() {
            return this.taskId;
        }

        public LiandanluTextToImageModelResponseBodyResult setTaskStatus(String taskStatus) {
            this.taskStatus = taskStatus;
            return this;
        }
        public String getTaskStatus() {
            return this.taskStatus;
        }

    }

}
