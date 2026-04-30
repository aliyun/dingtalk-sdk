// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class PageListNewAICreditsUsageRecordRequest extends TeaModel {
    @NameInMap("endTime")
    public String endTime;

    @NameInMap("pageNumber")
    public Long pageNumber;

    @NameInMap("pageSize")
    public Long pageSize;

    @NameInMap("scenarioName")
    public String scenarioName;

    @NameInMap("startTime")
    public String startTime;

    @NameInMap("userId")
    public String userId;

    @NameInMap("userName")
    public String userName;

    public static PageListNewAICreditsUsageRecordRequest build(java.util.Map<String, ?> map) throws Exception {
        PageListNewAICreditsUsageRecordRequest self = new PageListNewAICreditsUsageRecordRequest();
        return TeaModel.build(map, self);
    }

    public PageListNewAICreditsUsageRecordRequest setEndTime(String endTime) {
        this.endTime = endTime;
        return this;
    }
    public String getEndTime() {
        return this.endTime;
    }

    public PageListNewAICreditsUsageRecordRequest setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public PageListNewAICreditsUsageRecordRequest setPageSize(Long pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Long getPageSize() {
        return this.pageSize;
    }

    public PageListNewAICreditsUsageRecordRequest setScenarioName(String scenarioName) {
        this.scenarioName = scenarioName;
        return this;
    }
    public String getScenarioName() {
        return this.scenarioName;
    }

    public PageListNewAICreditsUsageRecordRequest setStartTime(String startTime) {
        this.startTime = startTime;
        return this;
    }
    public String getStartTime() {
        return this.startTime;
    }

    public PageListNewAICreditsUsageRecordRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public PageListNewAICreditsUsageRecordRequest setUserName(String userName) {
        this.userName = userName;
        return this;
    }
    public String getUserName() {
        return this.userName;
    }

}
