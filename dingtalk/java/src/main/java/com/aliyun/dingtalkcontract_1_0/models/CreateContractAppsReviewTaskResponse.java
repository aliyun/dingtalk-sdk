// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class CreateContractAppsReviewTaskResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateContractAppsReviewTaskResponseBody body;

    public static CreateContractAppsReviewTaskResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateContractAppsReviewTaskResponse self = new CreateContractAppsReviewTaskResponse();
        return TeaModel.build(map, self);
    }

    public CreateContractAppsReviewTaskResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateContractAppsReviewTaskResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateContractAppsReviewTaskResponse setBody(CreateContractAppsReviewTaskResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateContractAppsReviewTaskResponseBody getBody() {
        return this.body;
    }

}
