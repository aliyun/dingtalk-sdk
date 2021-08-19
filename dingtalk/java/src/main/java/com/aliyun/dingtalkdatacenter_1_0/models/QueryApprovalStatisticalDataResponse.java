// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryApprovalStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public QueryApprovalStatisticalDataResponse setBody(QueryApprovalStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryApprovalStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
