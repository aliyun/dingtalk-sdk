// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetGeneralFormCreatedDeptSummaryRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("maxResults")
    public Long maxResults;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("nextToken")
    public Long nextToken;

    public static GetGeneralFormCreatedDeptSummaryRequest build(java.util.Map<String, ?> map) throws Exception {
        GetGeneralFormCreatedDeptSummaryRequest self = new GetGeneralFormCreatedDeptSummaryRequest();
        return TeaModel.build(map, self);
    }

    public GetGeneralFormCreatedDeptSummaryRequest setMaxResults(Long maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Long getMaxResults() {
        return this.maxResults;
    }

    public GetGeneralFormCreatedDeptSummaryRequest setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

}
