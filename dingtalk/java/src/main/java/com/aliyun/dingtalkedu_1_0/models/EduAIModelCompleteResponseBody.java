// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class EduAIModelCompleteResponseBody extends TeaModel {
    @NameInMap("result")
    public EduAIModelCompleteResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static EduAIModelCompleteResponseBody build(java.util.Map<String, ?> map) throws Exception {
        EduAIModelCompleteResponseBody self = new EduAIModelCompleteResponseBody();
        return TeaModel.build(map, self);
    }

    public EduAIModelCompleteResponseBody setResult(EduAIModelCompleteResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public EduAIModelCompleteResponseBodyResult getResult() {
        return this.result;
    }

    public EduAIModelCompleteResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class EduAIModelCompleteResponseBodyResult extends TeaModel {
        @NameInMap("requestId")
        public String requestId;

        @NameInMap("result")
        public java.util.Map<String, ?> result;

        public static EduAIModelCompleteResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            EduAIModelCompleteResponseBodyResult self = new EduAIModelCompleteResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public EduAIModelCompleteResponseBodyResult setRequestId(String requestId) {
            this.requestId = requestId;
            return this;
        }
        public String getRequestId() {
            return this.requestId;
        }

        public EduAIModelCompleteResponseBodyResult setResult(java.util.Map<String, ?> result) {
            this.result = result;
            return this;
        }
        public java.util.Map<String, ?> getResult() {
            return this.result;
        }

    }

}
