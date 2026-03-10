// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class GetContractReviewResultResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetContractReviewResultResponseBody body;

    public static GetContractReviewResultResponse build(java.util.Map<String, ?> map) throws Exception {
        GetContractReviewResultResponse self = new GetContractReviewResultResponse();
        return TeaModel.build(map, self);
    }

    public GetContractReviewResultResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetContractReviewResultResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetContractReviewResultResponse setBody(GetContractReviewResultResponseBody body) {
        this.body = body;
        return this;
    }
    public GetContractReviewResultResponseBody getBody() {
        return this.body;
    }

}
