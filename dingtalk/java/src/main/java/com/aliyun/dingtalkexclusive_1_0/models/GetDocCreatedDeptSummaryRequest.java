// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetDocCreatedDeptSummaryRequest extends TeaModel {
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

    public static GetDocCreatedDeptSummaryRequest build(java.util.Map<String, ?> map) throws Exception {
        GetDocCreatedDeptSummaryRequest self = new GetDocCreatedDeptSummaryRequest();
        return TeaModel.build(map, self);
    }

    public GetDocCreatedDeptSummaryRequest setMaxResults(Long maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Long getMaxResults() {
        return this.maxResults;
    }

    public GetDocCreatedDeptSummaryRequest setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

}
