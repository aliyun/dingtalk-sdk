// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class QueryTaskOfProjectRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>10</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    /**
     * <strong>example:</strong>
     * <p>f279e812-e431-428d-846d-cxxxxxx</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <strong>example:</strong>
     * <p>involveMembers NOT IN [&quot;0612xx&quot;] AND executorId=&quot;057xxx&quot; AND content~标题2</p>
     */
    @NameInMap("query")
    public String query;

    public static QueryTaskOfProjectRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryTaskOfProjectRequest self = new QueryTaskOfProjectRequest();
        return TeaModel.build(map, self);
    }

    public QueryTaskOfProjectRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public QueryTaskOfProjectRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public QueryTaskOfProjectRequest setQuery(String query) {
        this.query = query;
        return this;
    }
    public String getQuery() {
        return this.query;
    }

}
