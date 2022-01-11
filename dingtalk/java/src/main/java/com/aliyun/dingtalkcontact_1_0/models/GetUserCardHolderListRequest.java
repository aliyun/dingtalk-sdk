// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class GetUserCardHolderListRequest extends TeaModel {
    // 每页返回个数
    @NameInMap("maxResults")
    public Integer maxResults;

    // 标记当前开始读取的位置，置空表示从头开始
    @NameInMap("nextToken")
    public Long nextToken;

    public static GetUserCardHolderListRequest build(java.util.Map<String, ?> map) throws Exception {
        GetUserCardHolderListRequest self = new GetUserCardHolderListRequest();
        return TeaModel.build(map, self);
    }

    public GetUserCardHolderListRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public GetUserCardHolderListRequest setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

}
