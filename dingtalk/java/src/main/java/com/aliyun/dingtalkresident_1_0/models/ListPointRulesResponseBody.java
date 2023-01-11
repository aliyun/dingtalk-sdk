// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class ListPointRulesResponseBody extends TeaModel {
    /**
     * <p>查询所得积分规则集合</p>
     */
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
        /**
         * <p>单日计次上限，0表示无上限</p>
         */
        @NameInMap("dayLimitTimes")
        public Integer dayLimitTimes;

        /**
         * <p>扩展字段</p>
         */
        @NameInMap("extension")
        public String extension;

        /**
         * <p>分组ID, 默认写入为0</p>
         */
        @NameInMap("groupId")
        public Integer groupId;

        /**
         * <p>排序ID</p>
         */
        @NameInMap("orderId")
        public Integer orderId;

        /**
         * <p>对应的行为代码（可空）</p>
         */
        @NameInMap("ruleCode")
        public String ruleCode;

        /**
         * <p>对应的行为名字</p>
         */
        @NameInMap("ruleName")
        public String ruleName;

        /**
         * <p>增加或减少的分数（增加为正数，减少为负数）</p>
         */
        @NameInMap("score")
        public Integer score;

        /**
         * <p>生效状态 0：不生效，1：生效</p>
         */
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
