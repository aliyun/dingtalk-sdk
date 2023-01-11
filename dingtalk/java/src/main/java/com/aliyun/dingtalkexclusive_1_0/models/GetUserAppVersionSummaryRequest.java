// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetUserAppVersionSummaryRequest extends TeaModel {
    /**
     * <p>每页包含的数据条数</p>
     */
    @NameInMap("maxResults")
    public Long maxResults;

    /**
     * <p>启始数据游标</p>
     */
    @NameInMap("nextToken")
    public Long nextToken;

    public static GetUserAppVersionSummaryRequest build(java.util.Map<String, ?> map) throws Exception {
        GetUserAppVersionSummaryRequest self = new GetUserAppVersionSummaryRequest();
        return TeaModel.build(map, self);
    }

    public GetUserAppVersionSummaryRequest setMaxResults(Long maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Long getMaxResults() {
        return this.maxResults;
    }

    public GetUserAppVersionSummaryRequest setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

}
