// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class SubmitAgentTaskResponseBody extends TeaModel {
    @NameInMap("result")
    public SubmitAgentTaskResponseBodyResult result;

    public static SubmitAgentTaskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SubmitAgentTaskResponseBody self = new SubmitAgentTaskResponseBody();
        return TeaModel.build(map, self);
    }

    public SubmitAgentTaskResponseBody setResult(SubmitAgentTaskResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public SubmitAgentTaskResponseBodyResult getResult() {
        return this.result;
    }

    public static class SubmitAgentTaskResponseBodyResult extends TeaModel {
        @NameInMap("taskId")
        public String taskId;

        public static SubmitAgentTaskResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            SubmitAgentTaskResponseBodyResult self = new SubmitAgentTaskResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public SubmitAgentTaskResponseBodyResult setTaskId(String taskId) {
            this.taskId = taskId;
            return this;
        }
        public String getTaskId() {
            return this.taskId;
        }

    }

}
