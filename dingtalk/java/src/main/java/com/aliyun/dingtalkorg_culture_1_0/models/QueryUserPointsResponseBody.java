// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkorg_culture_1_0.models;

import com.aliyun.tea.*;

public class QueryUserPointsResponseBody extends TeaModel {
    // 响应数据
    @NameInMap("result")
    public QueryUserPointsResponseBodyResult result;

    // 请求响应状态
    @NameInMap("success")
    public Boolean success;

    public static QueryUserPointsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryUserPointsResponseBody self = new QueryUserPointsResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryUserPointsResponseBody setResult(QueryUserPointsResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryUserPointsResponseBodyResult getResult() {
        return this.result;
    }

    public QueryUserPointsResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class QueryUserPointsResponseBodyResult extends TeaModel {
        // 员工积分数量
        @NameInMap("amount")
        public Long amount;

        public static QueryUserPointsResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryUserPointsResponseBodyResult self = new QueryUserPointsResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryUserPointsResponseBodyResult setAmount(Long amount) {
            this.amount = amount;
            return this;
        }
        public Long getAmount() {
            return this.amount;
        }

    }

}
