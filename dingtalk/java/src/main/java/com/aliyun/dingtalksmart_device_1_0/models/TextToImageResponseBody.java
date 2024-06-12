// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksmart_device_1_0.models;

import com.aliyun.tea.*;

public class TextToImageResponseBody extends TeaModel {
    @NameInMap("result")
    public TextToImageResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static TextToImageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        TextToImageResponseBody self = new TextToImageResponseBody();
        return TeaModel.build(map, self);
    }

    public TextToImageResponseBody setResult(TextToImageResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public TextToImageResponseBodyResult getResult() {
        return this.result;
    }

    public TextToImageResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class TextToImageResponseBodyResult extends TeaModel {
        @NameInMap("requestId")
        public String requestId;

        @NameInMap("taskId")
        public String taskId;

        @NameInMap("taskStatus")
        public String taskStatus;

        public static TextToImageResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            TextToImageResponseBodyResult self = new TextToImageResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public TextToImageResponseBodyResult setRequestId(String requestId) {
            this.requestId = requestId;
            return this;
        }
        public String getRequestId() {
            return this.requestId;
        }

        public TextToImageResponseBodyResult setTaskId(String taskId) {
            this.taskId = taskId;
            return this;
        }
        public String getTaskId() {
            return this.taskId;
        }

        public TextToImageResponseBodyResult setTaskStatus(String taskStatus) {
            this.taskStatus = taskStatus;
            return this;
        }
        public String getTaskStatus() {
            return this.taskStatus;
        }

    }

}
