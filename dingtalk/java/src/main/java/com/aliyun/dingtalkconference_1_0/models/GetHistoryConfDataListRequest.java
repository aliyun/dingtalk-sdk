// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class GetHistoryConfDataListRequest extends TeaModel {
    @NameInMap("creatorNike")
    public String creatorNike;

    @NameInMap("endTime")
    public Long endTime;

    @NameInMap("freeType")
    public String freeType;

    @NameInMap("maxResults")
    public Integer maxResults;

    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("realData")
    public Boolean realData;

    @NameInMap("scene")
    public String scene;

    @NameInMap("startTime")
    public Long startTime;

    @NameInMap("title")
    public String title;

    public static GetHistoryConfDataListRequest build(java.util.Map<String, ?> map) throws Exception {
        GetHistoryConfDataListRequest self = new GetHistoryConfDataListRequest();
        return TeaModel.build(map, self);
    }

    public GetHistoryConfDataListRequest setCreatorNike(String creatorNike) {
        this.creatorNike = creatorNike;
        return this;
    }
    public String getCreatorNike() {
        return this.creatorNike;
    }

    public GetHistoryConfDataListRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public GetHistoryConfDataListRequest setFreeType(String freeType) {
        this.freeType = freeType;
        return this;
    }
    public String getFreeType() {
        return this.freeType;
    }

    public GetHistoryConfDataListRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public GetHistoryConfDataListRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public GetHistoryConfDataListRequest setRealData(Boolean realData) {
        this.realData = realData;
        return this;
    }
    public Boolean getRealData() {
        return this.realData;
    }

    public GetHistoryConfDataListRequest setScene(String scene) {
        this.scene = scene;
        return this;
    }
    public String getScene() {
        return this.scene;
    }

    public GetHistoryConfDataListRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public GetHistoryConfDataListRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

}
