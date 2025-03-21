// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryUserViewGroupLastMessageTimeResponseBody extends TeaModel {
    @NameInMap("result")
    public QueryUserViewGroupLastMessageTimeResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static QueryUserViewGroupLastMessageTimeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryUserViewGroupLastMessageTimeResponseBody self = new QueryUserViewGroupLastMessageTimeResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryUserViewGroupLastMessageTimeResponseBody setResult(QueryUserViewGroupLastMessageTimeResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryUserViewGroupLastMessageTimeResponseBodyResult getResult() {
        return this.result;
    }

    public QueryUserViewGroupLastMessageTimeResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class QueryUserViewGroupLastMessageTimeResponseBodyResult extends TeaModel {
        @NameInMap("time")
        public Long time;

        public static QueryUserViewGroupLastMessageTimeResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryUserViewGroupLastMessageTimeResponseBodyResult self = new QueryUserViewGroupLastMessageTimeResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryUserViewGroupLastMessageTimeResponseBodyResult setTime(Long time) {
            this.time = time;
            return this;
        }
        public Long getTime() {
            return this.time;
        }

    }

}
