// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkorg_culture_1_0.models;

import com.aliyun.tea.*;

public class QueryCorpPointsResponseBody extends TeaModel {
    /**
     * <p>响应数据</p>
     */
    @NameInMap("result")
    public QueryCorpPointsResponseBodyResult result;

    /**
     * <p>请求响应状态</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static QueryCorpPointsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryCorpPointsResponseBody self = new QueryCorpPointsResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryCorpPointsResponseBody setResult(QueryCorpPointsResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryCorpPointsResponseBodyResult getResult() {
        return this.result;
    }

    public QueryCorpPointsResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class QueryCorpPointsResponseBodyResult extends TeaModel {
        /**
         * <p>企业员工可用于兑换积分总额</p>
         */
        @NameInMap("amount")
        public Long amount;

        public static QueryCorpPointsResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryCorpPointsResponseBodyResult self = new QueryCorpPointsResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryCorpPointsResponseBodyResult setAmount(Long amount) {
            this.amount = amount;
            return this;
        }
        public Long getAmount() {
            return this.amount;
        }

    }

}
