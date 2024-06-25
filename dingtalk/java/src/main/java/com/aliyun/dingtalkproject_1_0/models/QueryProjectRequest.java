// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class QueryProjectRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>10</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    /**
     * <strong>example:</strong>
     * <p>测试项目</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <strong>example:</strong>
     * <p>f279e812xxxxxx</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <strong>example:</strong>
     * <p>60a2187eb72xxxxxxx</p>
     */
    @NameInMap("projectIds")
    public String projectIds;

    /**
     * <strong>example:</strong>
     * <p>60a2187eb72xxxxxxx</p>
     */
    @NameInMap("sourceId")
    public String sourceId;

    public static QueryProjectRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryProjectRequest self = new QueryProjectRequest();
        return TeaModel.build(map, self);
    }

    public QueryProjectRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public QueryProjectRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public QueryProjectRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public QueryProjectRequest setProjectIds(String projectIds) {
        this.projectIds = projectIds;
        return this;
    }
    public String getProjectIds() {
        return this.projectIds;
    }

    public QueryProjectRequest setSourceId(String sourceId) {
        this.sourceId = sourceId;
        return this;
    }
    public String getSourceId() {
        return this.sourceId;
    }

}
