// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0.models;

import com.aliyun.tea.*;

public class QueryUserFollowStatusResponseBody extends TeaModel {
    /**
     * <p>响应结果</p>
     */
    @NameInMap("result")
    public QueryUserFollowStatusResponseBodyResult result;

    public static QueryUserFollowStatusResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryUserFollowStatusResponseBody self = new QueryUserFollowStatusResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryUserFollowStatusResponseBody setResult(QueryUserFollowStatusResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryUserFollowStatusResponseBodyResult getResult() {
        return this.result;
    }

    public static class QueryUserFollowStatusResponseBodyResult extends TeaModel {
        /**
         * <p>用户关注服务窗的状态:</p>
         * <p>FOLLOWED：已关注。</p>
         * <p>UNFOLLOW：未关注。</p>
         */
        @NameInMap("status")
        public String status;

        public static QueryUserFollowStatusResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryUserFollowStatusResponseBodyResult self = new QueryUserFollowStatusResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryUserFollowStatusResponseBodyResult setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

    }

}
