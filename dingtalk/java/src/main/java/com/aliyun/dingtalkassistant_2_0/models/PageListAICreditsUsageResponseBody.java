// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_2_0.models;

import com.aliyun.tea.*;

public class PageListAICreditsUsageResponseBody extends TeaModel {
    @NameInMap("dataList")
    public java.util.List<PageListAICreditsUsageResponseBodyDataList> dataList;

    @NameInMap("totalCount")
    public Long totalCount;

    public static PageListAICreditsUsageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PageListAICreditsUsageResponseBody self = new PageListAICreditsUsageResponseBody();
        return TeaModel.build(map, self);
    }

    public PageListAICreditsUsageResponseBody setDataList(java.util.List<PageListAICreditsUsageResponseBodyDataList> dataList) {
        this.dataList = dataList;
        return this;
    }
    public java.util.List<PageListAICreditsUsageResponseBodyDataList> getDataList() {
        return this.dataList;
    }

    public PageListAICreditsUsageResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public static class PageListAICreditsUsageResponseBodyDataList extends TeaModel {
        @NameInMap("abilityName")
        public String abilityName;

        @NameInMap("aiCreditsUsedNum")
        public Double aiCreditsUsedNum;

        @NameInMap("bizId")
        public String bizId;

        @NameInMap("deptName")
        public String deptName;

        @NameInMap("isTimeFree")
        public Boolean isTimeFree;

        @NameInMap("scenarioName")
        public String scenarioName;

        @NameInMap("taskName")
        public String taskName;

        @NameInMap("usageTime")
        public String usageTime;

        @NameInMap("userId")
        public String userId;

        @NameInMap("userName")
        public String userName;

        public static PageListAICreditsUsageResponseBodyDataList build(java.util.Map<String, ?> map) throws Exception {
            PageListAICreditsUsageResponseBodyDataList self = new PageListAICreditsUsageResponseBodyDataList();
            return TeaModel.build(map, self);
        }

        public PageListAICreditsUsageResponseBodyDataList setAbilityName(String abilityName) {
            this.abilityName = abilityName;
            return this;
        }
        public String getAbilityName() {
            return this.abilityName;
        }

        public PageListAICreditsUsageResponseBodyDataList setAiCreditsUsedNum(Double aiCreditsUsedNum) {
            this.aiCreditsUsedNum = aiCreditsUsedNum;
            return this;
        }
        public Double getAiCreditsUsedNum() {
            return this.aiCreditsUsedNum;
        }

        public PageListAICreditsUsageResponseBodyDataList setBizId(String bizId) {
            this.bizId = bizId;
            return this;
        }
        public String getBizId() {
            return this.bizId;
        }

        public PageListAICreditsUsageResponseBodyDataList setDeptName(String deptName) {
            this.deptName = deptName;
            return this;
        }
        public String getDeptName() {
            return this.deptName;
        }

        public PageListAICreditsUsageResponseBodyDataList setIsTimeFree(Boolean isTimeFree) {
            this.isTimeFree = isTimeFree;
            return this;
        }
        public Boolean getIsTimeFree() {
            return this.isTimeFree;
        }

        public PageListAICreditsUsageResponseBodyDataList setScenarioName(String scenarioName) {
            this.scenarioName = scenarioName;
            return this;
        }
        public String getScenarioName() {
            return this.scenarioName;
        }

        public PageListAICreditsUsageResponseBodyDataList setTaskName(String taskName) {
            this.taskName = taskName;
            return this;
        }
        public String getTaskName() {
            return this.taskName;
        }

        public PageListAICreditsUsageResponseBodyDataList setUsageTime(String usageTime) {
            this.usageTime = usageTime;
            return this;
        }
        public String getUsageTime() {
            return this.usageTime;
        }

        public PageListAICreditsUsageResponseBodyDataList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public PageListAICreditsUsageResponseBodyDataList setUserName(String userName) {
            this.userName = userName;
            return this;
        }
        public String getUserName() {
            return this.userName;
        }

    }

}
