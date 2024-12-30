// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class QueryContractReviewResultResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryContractReviewResultResponseBody body;

    public static QueryContractReviewResultResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryContractReviewResultResponse self = new QueryContractReviewResultResponse();
        return TeaModel.build(map, self);
    }

    public QueryContractReviewResultResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryContractReviewResultResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryContractReviewResultResponse setBody(QueryContractReviewResultResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryContractReviewResultResponseBody getBody() {
        return this.body;
    }

}
