// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class ListPointRulesResponseBody extends TeaModel {
    // 查询所得积分规则集合
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
        // 组织id
        @NameInMap("corpId")
        public String corpId;

        // 增加或减少的分数（增加为正数，减少为负数）
        @NameInMap("score")
        public Integer score;

        // 单日计次上限，0表示无上限
        @NameInMap("dayLimitTimes")
        public Integer dayLimitTimes;

        // 生效状态 0：不生效，1：生效
        @NameInMap("status")
        public Integer status;

        // 对应的行为代码（可空）
        @NameInMap("ruleCode")
        public String ruleCode;

        // 对应的行为名字
        @NameInMap("ruleName")
        public String ruleName;

        // 扩展字段
        @NameInMap("extension")
        public String extension;

        // 分组ID, 默认写入为0
        @NameInMap("groupId")
        public Integer groupId;

        // 排序ID
        @NameInMap("orderId")
        public Integer orderId;

        public static ListPointRulesResponseBodyPointRuleList build(java.util.Map<String, ?> map) throws Exception {
            ListPointRulesResponseBodyPointRuleList self = new ListPointRulesResponseBodyPointRuleList();
            return TeaModel.build(map, self);
        }

        public ListPointRulesResponseBodyPointRuleList setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public ListPointRulesResponseBodyPointRuleList setScore(Integer score) {
            this.score = score;
            return this;
        }
        public Integer getScore() {
            return this.score;
        }

        public ListPointRulesResponseBodyPointRuleList setDayLimitTimes(Integer dayLimitTimes) {
            this.dayLimitTimes = dayLimitTimes;
            return this;
        }
        public Integer getDayLimitTimes() {
            return this.dayLimitTimes;
        }

        public ListPointRulesResponseBodyPointRuleList setStatus(Integer status) {
            this.status = status;
            return this;
        }
        public Integer getStatus() {
            return this.status;
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

    }

}
