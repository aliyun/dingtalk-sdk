// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetDingReportDeptSummaryRequest extends TeaModel {
    // 启始数据游标
    @NameInMap("nextToken")
    public Long nextToken;

    // 每页包含的数据条数
    @NameInMap("maxResults")
    public Long maxResults;

    public static GetDingReportDeptSummaryRequest build(java.util.Map<String, ?> map) throws Exception {
        GetDingReportDeptSummaryRequest self = new GetDingReportDeptSummaryRequest();
        return TeaModel.build(map, self);
    }

    public GetDingReportDeptSummaryRequest setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

    public GetDingReportDeptSummaryRequest setMaxResults(Long maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Long getMaxResults() {
        return this.maxResults;
    }

}
