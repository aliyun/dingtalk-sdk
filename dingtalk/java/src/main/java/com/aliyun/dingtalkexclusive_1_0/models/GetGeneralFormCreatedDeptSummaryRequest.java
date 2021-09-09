// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetGeneralFormCreatedDeptSummaryRequest extends TeaModel {
    // 启始数据游标
    @NameInMap("nextToken")
    public Long nextToken;

    // 每页包含的数据条数
    @NameInMap("maxResults")
    public Long maxResults;

    public static GetGeneralFormCreatedDeptSummaryRequest build(java.util.Map<String, ?> map) throws Exception {
        GetGeneralFormCreatedDeptSummaryRequest self = new GetGeneralFormCreatedDeptSummaryRequest();
        return TeaModel.build(map, self);
    }

    public GetGeneralFormCreatedDeptSummaryRequest setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

    public GetGeneralFormCreatedDeptSummaryRequest setMaxResults(Long maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Long getMaxResults() {
        return this.maxResults;
    }

}
