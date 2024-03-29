// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryApprovalStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryApprovalStatisticalDataResponseBody body;

    public static QueryApprovalStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryApprovalStatisticalDataResponse self = new QueryApprovalStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryApprovalStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryApprovalStatisticalDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryApprovalStatisticalDataResponse setBody(QueryApprovalStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryApprovalStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
