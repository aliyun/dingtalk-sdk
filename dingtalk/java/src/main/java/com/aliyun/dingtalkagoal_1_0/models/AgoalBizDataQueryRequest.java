// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class AgoalBizDataQueryRequest extends TeaModel {
    @NameInMap("bizCode")
    public String bizCode;

    @NameInMap("maxResults")
    public Long maxResults;

    @NameInMap("nextToken")
    public String nextToken;

    public static AgoalBizDataQueryRequest build(java.util.Map<String, ?> map) throws Exception {
        AgoalBizDataQueryRequest self = new AgoalBizDataQueryRequest();
        return TeaModel.build(map, self);
    }

    public AgoalBizDataQueryRequest setBizCode(String bizCode) {
        this.bizCode = bizCode;
        return this;
    }
    public String getBizCode() {
        return this.bizCode;
    }

    public AgoalBizDataQueryRequest setMaxResults(Long maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Long getMaxResults() {
        return this.maxResults;
    }

    public AgoalBizDataQueryRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

}
