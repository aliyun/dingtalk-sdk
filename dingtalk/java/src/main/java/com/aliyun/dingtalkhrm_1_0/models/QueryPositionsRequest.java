// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class QueryPositionsRequest extends TeaModel {
    // 职位名称
    @NameInMap("positionName")
    public String positionName;

    // 职位类别列表
    @NameInMap("inCategoryIds")
    public java.util.List<String> inCategoryIds;

    // 职位id列表
    @NameInMap("inPositionIds")
    public java.util.List<String> inPositionIds;

    // 偏移量
    @NameInMap("nextToken")
    public Integer nextToken;

    // 一次查询获取记录数
    @NameInMap("maxResults")
    public Integer maxResults;

    public static QueryPositionsRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryPositionsRequest self = new QueryPositionsRequest();
        return TeaModel.build(map, self);
    }

    public QueryPositionsRequest setPositionName(String positionName) {
        this.positionName = positionName;
        return this;
    }
    public String getPositionName() {
        return this.positionName;
    }

    public QueryPositionsRequest setInCategoryIds(java.util.List<String> inCategoryIds) {
        this.inCategoryIds = inCategoryIds;
        return this;
    }
    public java.util.List<String> getInCategoryIds() {
        return this.inCategoryIds;
    }

    public QueryPositionsRequest setInPositionIds(java.util.List<String> inPositionIds) {
        this.inPositionIds = inPositionIds;
        return this;
    }
    public java.util.List<String> getInPositionIds() {
        return this.inPositionIds;
    }

    public QueryPositionsRequest setNextToken(Integer nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Integer getNextToken() {
        return this.nextToken;
    }

    public QueryPositionsRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

}
