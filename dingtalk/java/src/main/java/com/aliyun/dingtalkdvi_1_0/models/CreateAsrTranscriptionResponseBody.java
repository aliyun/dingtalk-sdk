// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class CreateAsrTranscriptionResponseBody extends TeaModel {
    @NameInMap("result")
    public CreateAsrTranscriptionResponseBodyResult result;

    public static CreateAsrTranscriptionResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateAsrTranscriptionResponseBody self = new CreateAsrTranscriptionResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateAsrTranscriptionResponseBody setResult(CreateAsrTranscriptionResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public CreateAsrTranscriptionResponseBodyResult getResult() {
        return this.result;
    }

    public static class CreateAsrTranscriptionResponseBodyResult extends TeaModel {
        @NameInMap("taskId")
        public String taskId;

        public static CreateAsrTranscriptionResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            CreateAsrTranscriptionResponseBodyResult self = new CreateAsrTranscriptionResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public CreateAsrTranscriptionResponseBodyResult setTaskId(String taskId) {
            this.taskId = taskId;
            return this;
        }
        public String getTaskId() {
            return this.taskId;
        }

    }

}
