// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class CreateContractReviewResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateContractReviewResponseBody body;

    public static CreateContractReviewResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateContractReviewResponse self = new CreateContractReviewResponse();
        return TeaModel.build(map, self);
    }

    public CreateContractReviewResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateContractReviewResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateContractReviewResponse setBody(CreateContractReviewResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateContractReviewResponseBody getBody() {
        return this.body;
    }

}
