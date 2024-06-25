// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class GetHistoryConfDataListRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>张三</p>
     */
    @NameInMap("creatorNike")
    public String creatorNike;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1682611199000</p>
     */
    @NameInMap("endTime")
    public Long endTime;

    /**
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("freeType")
    public String freeType;

    /**
     * <strong>example:</strong>
     * <p>100</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    /**
     * <strong>example:</strong>
     * <p>xxx9uZ0bVGoqjxxxxxxxx</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("realData")
    public Boolean realData;

    /**
     * <strong>example:</strong>
     * <p>ding_talk</p>
     */
    @NameInMap("scene")
    public String scene;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1682524800000</p>
     */
    @NameInMap("startTime")
    public Long startTime;

    /**
     * <strong>example:</strong>
     * <p>xxxxx视频会议</p>
     */
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
