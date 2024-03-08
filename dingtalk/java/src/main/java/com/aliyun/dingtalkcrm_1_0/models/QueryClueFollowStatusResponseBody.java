// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class QueryClueFollowStatusResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<QueryClueFollowStatusResponseBodyResult> result;

    public static QueryClueFollowStatusResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryClueFollowStatusResponseBody self = new QueryClueFollowStatusResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryClueFollowStatusResponseBody setResult(java.util.List<QueryClueFollowStatusResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<QueryClueFollowStatusResponseBodyResult> getResult() {
        return this.result;
    }

    public static class QueryClueFollowStatusResponseBodyResult extends TeaModel {
        @NameInMap("clueId")
        public String clueId;

        @NameInMap("scope")
        public String scope;

        @NameInMap("status")
        public String status;

        public static QueryClueFollowStatusResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryClueFollowStatusResponseBodyResult self = new QueryClueFollowStatusResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryClueFollowStatusResponseBodyResult setClueId(String clueId) {
            this.clueId = clueId;
            return this;
        }
        public String getClueId() {
            return this.clueId;
        }

        public QueryClueFollowStatusResponseBodyResult setScope(String scope) {
            this.scope = scope;
            return this;
        }
        public String getScope() {
            return this.scope;
        }

        public QueryClueFollowStatusResponseBodyResult setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

    }

}
