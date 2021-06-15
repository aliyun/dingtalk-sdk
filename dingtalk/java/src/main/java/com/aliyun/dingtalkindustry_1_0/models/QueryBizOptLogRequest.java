// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryBizOptLogRequest extends TeaModel {
    // 拉取记录的起始位置，默认从上次拉取的最后位置开始
    @NameInMap("nextToken")
    public Long nextToken;

    // 每次拉取的数据量，最大200条
    @NameInMap("maxResults")
    public Integer maxResults;

    public static QueryBizOptLogRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryBizOptLogRequest self = new QueryBizOptLogRequest();
        return TeaModel.build(map, self);
    }

    public QueryBizOptLogRequest setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

    public QueryBizOptLogRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

}
