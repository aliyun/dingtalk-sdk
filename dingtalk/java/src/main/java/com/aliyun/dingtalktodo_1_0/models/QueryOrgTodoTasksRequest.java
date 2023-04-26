// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class QueryOrgTodoTasksRequest extends TeaModel {
    @NameInMap("isDone")
    public Boolean isDone;

    @NameInMap("nextToken")
    public String nextToken;

    public static QueryOrgTodoTasksRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryOrgTodoTasksRequest self = new QueryOrgTodoTasksRequest();
        return TeaModel.build(map, self);
    }

    public QueryOrgTodoTasksRequest setIsDone(Boolean isDone) {
        this.isDone = isDone;
        return this;
    }
    public Boolean getIsDone() {
        return this.isDone;
    }

    public QueryOrgTodoTasksRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

}
