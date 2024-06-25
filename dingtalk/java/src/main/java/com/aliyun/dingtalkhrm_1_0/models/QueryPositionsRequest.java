// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class QueryPositionsRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>部门id</p>
     */
    @NameInMap("deptId")
    public Long deptId;

    @NameInMap("inCategoryIds")
    public java.util.List<String> inCategoryIds;

    @NameInMap("inPositionIds")
    public java.util.List<String> inPositionIds;

    /**
     * <strong>example:</strong>
     * <p>职位名称</p>
     */
    @NameInMap("positionName")
    public String positionName;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("nextToken")
    public Integer nextToken;

    public static QueryPositionsRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryPositionsRequest self = new QueryPositionsRequest();
        return TeaModel.build(map, self);
    }

    public QueryPositionsRequest setDeptId(Long deptId) {
        this.deptId = deptId;
        return this;
    }
    public Long getDeptId() {
        return this.deptId;
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

    public QueryPositionsRequest setPositionName(String positionName) {
        this.positionName = positionName;
        return this;
    }
    public String getPositionName() {
        return this.positionName;
    }

    public QueryPositionsRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public QueryPositionsRequest setNextToken(Integer nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Integer getNextToken() {
        return this.nextToken;
    }

}
