// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_paa_s_1_0.models;

import com.aliyun.tea.*;

public class SubmitMemoryLearningTaskResponseBody extends TeaModel {
    @NameInMap("result")
    public SubmitMemoryLearningTaskResponseBodyResult result;

    public static SubmitMemoryLearningTaskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SubmitMemoryLearningTaskResponseBody self = new SubmitMemoryLearningTaskResponseBody();
        return TeaModel.build(map, self);
    }

    public SubmitMemoryLearningTaskResponseBody setResult(SubmitMemoryLearningTaskResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public SubmitMemoryLearningTaskResponseBodyResult getResult() {
        return this.result;
    }

    public static class SubmitMemoryLearningTaskResponseBodyResult extends TeaModel {
        @NameInMap("learningCode")
        public String learningCode;

        @NameInMap("status")
        public String status;

        @NameInMap("success")
        public Boolean success;

        public static SubmitMemoryLearningTaskResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            SubmitMemoryLearningTaskResponseBodyResult self = new SubmitMemoryLearningTaskResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public SubmitMemoryLearningTaskResponseBodyResult setLearningCode(String learningCode) {
            this.learningCode = learningCode;
            return this;
        }
        public String getLearningCode() {
            return this.learningCode;
        }

        public SubmitMemoryLearningTaskResponseBodyResult setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public SubmitMemoryLearningTaskResponseBodyResult setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

    }

}
