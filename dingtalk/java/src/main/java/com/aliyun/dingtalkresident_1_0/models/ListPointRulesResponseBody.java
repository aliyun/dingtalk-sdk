// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class ListPointRulesResponseBody extends TeaModel {
    @NameInMap("pointRuleList")
    public java.util.List<ListPointRulesResponseBodyPointRuleList> pointRuleList;

    public static ListPointRulesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListPointRulesResponseBody self = new ListPointRulesResponseBody();
        return TeaModel.build(map, self);
    }

    public ListPointRulesResponseBody setPointRuleList(java.util.List<ListPointRulesResponseBodyPointRuleList> pointRuleList) {
        this.pointRuleList = pointRuleList;
        return this;
    }
    public java.util.List<ListPointRulesResponseBodyPointRuleList> getPointRuleList() {
        return this.pointRuleList;
    }

    public static class ListPointRulesResponseBodyPointRuleList extends TeaModel {
        @NameInMap("dayLimitTimes")
        public Integer dayLimitTimes;

        @NameInMap("extension")
        public String extension;

        @NameInMap("groupId")
        public Integer groupId;

        @NameInMap("orderId")
        public Integer orderId;

        @NameInMap("ruleCode")
        public String ruleCode;

        @NameInMap("ruleName")
        public String ruleName;

        @NameInMap("score")
        public Integer score;

        @NameInMap("status")
        public Integer status;

        public static ListPointRulesResponseBodyPointRuleList build(java.util.Map<String, ?> map) throws Exception {
            ListPointRulesResponseBodyPointRuleList self = new ListPointRulesResponseBodyPointRuleList();
            return TeaModel.build(map, self);
        }

        public ListPointRulesResponseBodyPointRuleList setDayLimitTimes(Integer dayLimitTimes) {
            this.dayLimitTimes = dayLimitTimes;
            return this;
        }
        public Integer getDayLimitTimes() {
            return this.dayLimitTimes;
        }

        public ListPointRulesResponseBodyPointRuleList setExtension(String extension) {
            this.extension = extension;
            return this;
        }
        public String getExtension() {
            return this.extension;
        }

        public ListPointRulesResponseBodyPointRuleList setGroupId(Integer groupId) {
            this.groupId = groupId;
            return this;
        }
        public Integer getGroupId() {
            return this.groupId;
        }

        public ListPointRulesResponseBodyPointRuleList setOrderId(Integer orderId) {
            this.orderId = orderId;
            return this;
        }
        public Integer getOrderId() {
            return this.orderId;
        }

        public ListPointRulesResponseBodyPointRuleList setRuleCode(String ruleCode) {
            this.ruleCode = ruleCode;
            return this;
        }
        public String getRuleCode() {
            return this.ruleCode;
        }

        public ListPointRulesResponseBodyPointRuleList setRuleName(String ruleName) {
            this.ruleName = ruleName;
            return this;
        }
        public String getRuleName() {
            return this.ruleName;
        }

        public ListPointRulesResponseBodyPointRuleList setScore(Integer score) {
            this.score = score;
            return this;
        }
        public Integer getScore() {
            return this.score;
        }

        public ListPointRulesResponseBodyPointRuleList setStatus(Integer status) {
            this.status = status;
            return this;
        }
        public Integer getStatus() {
            return this.status;
        }

    }

}
