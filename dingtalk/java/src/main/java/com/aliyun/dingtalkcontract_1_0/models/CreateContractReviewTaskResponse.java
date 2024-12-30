// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class CreateContractReviewTaskResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateContractReviewTaskResponseBody body;

    public static CreateContractReviewTaskResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateContractReviewTaskResponse self = new CreateContractReviewTaskResponse();
        return TeaModel.build(map, self);
    }

    public CreateContractReviewTaskResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateContractReviewTaskResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateContractReviewTaskResponse setBody(CreateContractReviewTaskResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateContractReviewTaskResponseBody getBody() {
        return this.body;
    }

}
