// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryModelResultByTaskIdResponseBody extends TeaModel {
    @NameInMap("result")
    public QueryModelResultByTaskIdResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static QueryModelResultByTaskIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryModelResultByTaskIdResponseBody self = new QueryModelResultByTaskIdResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryModelResultByTaskIdResponseBody setResult(QueryModelResultByTaskIdResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryModelResultByTaskIdResponseBodyResult getResult() {
        return this.result;
    }

    public QueryModelResultByTaskIdResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class QueryModelResultByTaskIdResponseBodyResult extends TeaModel {
        @NameInMap("requestId")
        public String requestId;

        @NameInMap("result")
        public java.util.Map<String, ?> result;

        public static QueryModelResultByTaskIdResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryModelResultByTaskIdResponseBodyResult self = new QueryModelResultByTaskIdResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryModelResultByTaskIdResponseBodyResult setRequestId(String requestId) {
            this.requestId = requestId;
            return this;
        }
        public String getRequestId() {
            return this.requestId;
        }

        public QueryModelResultByTaskIdResponseBodyResult setResult(java.util.Map<String, ?> result) {
            this.result = result;
            return this;
        }
        public java.util.Map<String, ?> getResult() {
            return this.result;
        }

    }

}
