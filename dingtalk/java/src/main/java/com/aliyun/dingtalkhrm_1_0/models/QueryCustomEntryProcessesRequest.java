// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class QueryCustomEntryProcessesRequest extends TeaModel {
    // 最大值
    @NameInMap("maxResults")
    public Integer maxResults;

    // 偏移量
    @NameInMap("nextToken")
    public Integer nextToken;

    // 操作人id
    @NameInMap("operateUserId")
    public String operateUserId;

    public static QueryCustomEntryProcessesRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryCustomEntryProcessesRequest self = new QueryCustomEntryProcessesRequest();
        return TeaModel.build(map, self);
    }

    public QueryCustomEntryProcessesRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public QueryCustomEntryProcessesRequest setNextToken(Integer nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Integer getNextToken() {
        return this.nextToken;
    }

    public QueryCustomEntryProcessesRequest setOperateUserId(String operateUserId) {
        this.operateUserId = operateUserId;
        return this;
    }
    public String getOperateUserId() {
        return this.operateUserId;
    }

}
