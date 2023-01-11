// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class QueryTaskOfProjectRequest extends TeaModel {
    /**
     * <p>每页返回最大数量。默认10，最大500。</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    /**
     * <p>供分页使用，下一页token，从当前页结果中获取。</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>查询条件。如：“content ~ 标题1” 表示查询任务标题包含“标题1”的任务；“executor=05178xxxxx” 表示执行者是05178xxxx的任务；”involveMembers NOT IN["061xx","06112xx"] AND executorId=0673xxx AND content~标题2“ 表示查询参与者不是”061xx“和”06112xx“ 并且 执行者是0673xxx 并且 标题类似 ”标题2“的所有任务。</p>
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
