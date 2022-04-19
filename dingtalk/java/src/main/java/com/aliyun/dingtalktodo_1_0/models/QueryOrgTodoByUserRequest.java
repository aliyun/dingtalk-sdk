// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class QueryOrgTodoByUserRequest extends TeaModel {
    // 待办完成状态。
    @NameInMap("isDone")
    public Boolean isDone;

    // 每页数量。
    @NameInMap("maxResults")
    public Integer maxResults;

    // 分页游标。如果一个查询条件一次无法全部返回结果，会返回分页token，下次查询带上该token后会返回后续数据，直到分页token为null表示数据已经全部查询完毕。
    @NameInMap("nextToken")
    public String nextToken;

    public static QueryOrgTodoByUserRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryOrgTodoByUserRequest self = new QueryOrgTodoByUserRequest();
        return TeaModel.build(map, self);
    }

    public QueryOrgTodoByUserRequest setIsDone(Boolean isDone) {
        this.isDone = isDone;
        return this;
    }
    public Boolean getIsDone() {
        return this.isDone;
    }

    public QueryOrgTodoByUserRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public QueryOrgTodoByUserRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

}
