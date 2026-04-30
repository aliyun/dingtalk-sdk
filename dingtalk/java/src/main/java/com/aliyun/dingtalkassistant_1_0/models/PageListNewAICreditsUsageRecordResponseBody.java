// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class PageListNewAICreditsUsageRecordResponseBody extends TeaModel {
    @NameInMap("dataList")
    public java.util.List<PageListNewAICreditsUsageRecordResponseBodyDataList> dataList;

    @NameInMap("totalCount")
    public Long totalCount;

    public static PageListNewAICreditsUsageRecordResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PageListNewAICreditsUsageRecordResponseBody self = new PageListNewAICreditsUsageRecordResponseBody();
        return TeaModel.build(map, self);
    }

    public PageListNewAICreditsUsageRecordResponseBody setDataList(java.util.List<PageListNewAICreditsUsageRecordResponseBodyDataList> dataList) {
        this.dataList = dataList;
        return this;
    }
    public java.util.List<PageListNewAICreditsUsageRecordResponseBodyDataList> getDataList() {
        return this.dataList;
    }

    public PageListNewAICreditsUsageRecordResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public static class PageListNewAICreditsUsageRecordResponseBodyDataList extends TeaModel {
        @NameInMap("abilityName")
        public String abilityName;

        @NameInMap("aiCreditsUsedNum")
        public String aiCreditsUsedNum;

        @NameInMap("bizId")
        public String bizId;

        @NameInMap("isTimeFree")
        public String isTimeFree;

        @NameInMap("scenarioName")
        public String scenarioName;

        @NameInMap("taskName")
        public String taskName;

        @NameInMap("usageTime")
        public String usageTime;

        @NameInMap("userName")
        public String userName;

        public static PageListNewAICreditsUsageRecordResponseBodyDataList build(java.util.Map<String, ?> map) throws Exception {
            PageListNewAICreditsUsageRecordResponseBodyDataList self = new PageListNewAICreditsUsageRecordResponseBodyDataList();
            return TeaModel.build(map, self);
        }

        public PageListNewAICreditsUsageRecordResponseBodyDataList setAbilityName(String abilityName) {
            this.abilityName = abilityName;
            return this;
        }
        public String getAbilityName() {
            return this.abilityName;
        }

        public PageListNewAICreditsUsageRecordResponseBodyDataList setAiCreditsUsedNum(String aiCreditsUsedNum) {
            this.aiCreditsUsedNum = aiCreditsUsedNum;
            return this;
        }
        public String getAiCreditsUsedNum() {
            return this.aiCreditsUsedNum;
        }

        public PageListNewAICreditsUsageRecordResponseBodyDataList setBizId(String bizId) {
            this.bizId = bizId;
            return this;
        }
        public String getBizId() {
            return this.bizId;
        }

        public PageListNewAICreditsUsageRecordResponseBodyDataList setIsTimeFree(String isTimeFree) {
            this.isTimeFree = isTimeFree;
            return this;
        }
        public String getIsTimeFree() {
            return this.isTimeFree;
        }

        public PageListNewAICreditsUsageRecordResponseBodyDataList setScenarioName(String scenarioName) {
            this.scenarioName = scenarioName;
            return this;
        }
        public String getScenarioName() {
            return this.scenarioName;
        }

        public PageListNewAICreditsUsageRecordResponseBodyDataList setTaskName(String taskName) {
            this.taskName = taskName;
            return this;
        }
        public String getTaskName() {
            return this.taskName;
        }

        public PageListNewAICreditsUsageRecordResponseBodyDataList setUsageTime(String usageTime) {
            this.usageTime = usageTime;
            return this;
        }
        public String getUsageTime() {
            return this.usageTime;
        }

        public PageListNewAICreditsUsageRecordResponseBodyDataList setUserName(String userName) {
            this.userName = userName;
            return this;
        }
        public String getUserName() {
            return this.userName;
        }

    }

}
