// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_2_0.models;

import com.aliyun.tea.*;

public class PageListAICreditsUsageRequest extends TeaModel {
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

    public static PageListAICreditsUsageRequest build(java.util.Map<String, ?> map) throws Exception {
        PageListAICreditsUsageRequest self = new PageListAICreditsUsageRequest();
        return TeaModel.build(map, self);
    }

    public PageListAICreditsUsageRequest setEndTime(String endTime) {
        this.endTime = endTime;
        return this;
    }
    public String getEndTime() {
        return this.endTime;
    }

    public PageListAICreditsUsageRequest setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public PageListAICreditsUsageRequest setPageSize(Long pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Long getPageSize() {
        return this.pageSize;
    }

    public PageListAICreditsUsageRequest setScenarioName(String scenarioName) {
        this.scenarioName = scenarioName;
        return this;
    }
    public String getScenarioName() {
        return this.scenarioName;
    }

    public PageListAICreditsUsageRequest setStartTime(String startTime) {
        this.startTime = startTime;
        return this;
    }
    public String getStartTime() {
        return this.startTime;
    }

    public PageListAICreditsUsageRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public PageListAICreditsUsageRequest setUserName(String userName) {
        this.userName = userName;
        return this;
    }
    public String getUserName() {
        return this.userName;
    }

}
