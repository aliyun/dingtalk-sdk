// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<QueryResponseBodyResult> result;

    @NameInMap("success")
    public Boolean success;

    public static QueryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryResponseBody self = new QueryResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryResponseBody setResult(java.util.List<QueryResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<QueryResponseBodyResult> getResult() {
        return this.result;
    }

    public QueryResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class QueryResponseBodyResult extends TeaModel {
        @NameInMap("name")
        public String name;

        @NameInMap("ownerCode")
        public String ownerCode;

        public static QueryResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryResponseBodyResult self = new QueryResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QueryResponseBodyResult setOwnerCode(String ownerCode) {
            this.ownerCode = ownerCode;
            return this;
        }
        public String getOwnerCode() {
            return this.ownerCode;
        }

    }

}
