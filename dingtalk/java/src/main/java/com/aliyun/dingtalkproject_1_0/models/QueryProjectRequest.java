// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class QueryProjectRequest extends TeaModel {
    /**
     * <p>分页大小。每页返回最大数量。默认10，最大300。</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    /**
     * <p>项目名字(模糊匹配)。</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>分页标。供分页使用，下一页token，从当前页结果中获取。</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>项目ID集合，逗号分隔。</p>
     */
    @NameInMap("projectIds")
    public String projectIds;

    /**
     * <p>原始项目ID。</p>
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
