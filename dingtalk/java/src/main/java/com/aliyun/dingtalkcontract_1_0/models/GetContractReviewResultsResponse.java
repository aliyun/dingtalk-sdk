// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class GetContractReviewResultsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetContractReviewResultsResponseBody body;

    public static GetContractReviewResultsResponse build(java.util.Map<String, ?> map) throws Exception {
        GetContractReviewResultsResponse self = new GetContractReviewResultsResponse();
        return TeaModel.build(map, self);
    }

    public GetContractReviewResultsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetContractReviewResultsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetContractReviewResultsResponse setBody(GetContractReviewResultsResponseBody body) {
        this.body = body;
        return this;
    }
    public GetContractReviewResultsResponseBody getBody() {
        return this.body;
    }

}
