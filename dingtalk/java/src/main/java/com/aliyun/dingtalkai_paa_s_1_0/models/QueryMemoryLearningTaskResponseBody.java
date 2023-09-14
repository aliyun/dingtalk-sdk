// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_paa_s_1_0.models;

import com.aliyun.tea.*;

public class QueryMemoryLearningTaskResponseBody extends TeaModel {
    @NameInMap("result")
    public QueryMemoryLearningTaskResponseBodyResult result;

    public static QueryMemoryLearningTaskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryMemoryLearningTaskResponseBody self = new QueryMemoryLearningTaskResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryMemoryLearningTaskResponseBody setResult(QueryMemoryLearningTaskResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryMemoryLearningTaskResponseBodyResult getResult() {
        return this.result;
    }

    public static class QueryMemoryLearningTaskResponseBodyResult extends TeaModel {
        @NameInMap("status")
        public String status;

        @NameInMap("success")
        public Boolean success;

        public static QueryMemoryLearningTaskResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryMemoryLearningTaskResponseBodyResult self = new QueryMemoryLearningTaskResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryMemoryLearningTaskResponseBodyResult setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public QueryMemoryLearningTaskResponseBodyResult setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

    }

}
