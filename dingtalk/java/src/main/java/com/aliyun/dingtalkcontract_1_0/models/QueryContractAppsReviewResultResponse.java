// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class QueryContractAppsReviewResultResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryContractAppsReviewResultResponseBody body;

    public static QueryContractAppsReviewResultResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryContractAppsReviewResultResponse self = new QueryContractAppsReviewResultResponse();
        return TeaModel.build(map, self);
    }

    public QueryContractAppsReviewResultResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryContractAppsReviewResultResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryContractAppsReviewResultResponse setBody(QueryContractAppsReviewResultResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryContractAppsReviewResultResponseBody getBody() {
        return this.body;
    }

}
