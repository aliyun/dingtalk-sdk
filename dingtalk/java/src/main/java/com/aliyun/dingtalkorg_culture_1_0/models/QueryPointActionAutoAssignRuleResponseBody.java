// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkorg_culture_1_0.models;

import com.aliyun.tea.*;

public class QueryPointActionAutoAssignRuleResponseBody extends TeaModel {
    @NameInMap("result")
    public QueryPointActionAutoAssignRuleResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static QueryPointActionAutoAssignRuleResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryPointActionAutoAssignRuleResponseBody self = new QueryPointActionAutoAssignRuleResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryPointActionAutoAssignRuleResponseBody setResult(QueryPointActionAutoAssignRuleResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryPointActionAutoAssignRuleResponseBodyResult getResult() {
        return this.result;
    }

    public QueryPointActionAutoAssignRuleResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class QueryPointActionAutoAssignRuleResponseBodyResultQueryPointRuleResponseDTOS extends TeaModel {
        /**
         * <p>奖励积分</p>
         */
        @NameInMap("awardScore")
        public Long awardScore;

        /**
         * <p>行为名称</p>
         */
        @NameInMap("code")
        public String code;

        /**
         * <p>单日计次上限</p>
         */
        @NameInMap("dayLimitTimes")
        public Long dayLimitTimes;

        /**
         * <p>行为描述</p>
         */
        @NameInMap("description")
        public String description;

        /**
         * <p>生效状态：0无效，1有效</p>
         */
        @NameInMap("status")
        public Long status;

        public static QueryPointActionAutoAssignRuleResponseBodyResultQueryPointRuleResponseDTOS build(java.util.Map<String, ?> map) throws Exception {
            QueryPointActionAutoAssignRuleResponseBodyResultQueryPointRuleResponseDTOS self = new QueryPointActionAutoAssignRuleResponseBodyResultQueryPointRuleResponseDTOS();
            return TeaModel.build(map, self);
        }

        public QueryPointActionAutoAssignRuleResponseBodyResultQueryPointRuleResponseDTOS setAwardScore(Long awardScore) {
            this.awardScore = awardScore;
            return this;
        }
        public Long getAwardScore() {
            return this.awardScore;
        }

        public QueryPointActionAutoAssignRuleResponseBodyResultQueryPointRuleResponseDTOS setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public QueryPointActionAutoAssignRuleResponseBodyResultQueryPointRuleResponseDTOS setDayLimitTimes(Long dayLimitTimes) {
            this.dayLimitTimes = dayLimitTimes;
            return this;
        }
        public Long getDayLimitTimes() {
            return this.dayLimitTimes;
        }

        public QueryPointActionAutoAssignRuleResponseBodyResultQueryPointRuleResponseDTOS setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public QueryPointActionAutoAssignRuleResponseBodyResultQueryPointRuleResponseDTOS setStatus(Long status) {
            this.status = status;
            return this;
        }
        public Long getStatus() {
            return this.status;
        }

    }

    public static class QueryPointActionAutoAssignRuleResponseBodyResult extends TeaModel {
        /**
         * <p>行为规则列表</p>
         */
        @NameInMap("queryPointRuleResponseDTOS")
        public java.util.List<QueryPointActionAutoAssignRuleResponseBodyResultQueryPointRuleResponseDTOS> queryPointRuleResponseDTOS;

        public static QueryPointActionAutoAssignRuleResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryPointActionAutoAssignRuleResponseBodyResult self = new QueryPointActionAutoAssignRuleResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryPointActionAutoAssignRuleResponseBodyResult setQueryPointRuleResponseDTOS(java.util.List<QueryPointActionAutoAssignRuleResponseBodyResultQueryPointRuleResponseDTOS> queryPointRuleResponseDTOS) {
            this.queryPointRuleResponseDTOS = queryPointRuleResponseDTOS;
            return this;
        }
        public java.util.List<QueryPointActionAutoAssignRuleResponseBodyResultQueryPointRuleResponseDTOS> getQueryPointRuleResponseDTOS() {
            return this.queryPointRuleResponseDTOS;
        }

    }

}
