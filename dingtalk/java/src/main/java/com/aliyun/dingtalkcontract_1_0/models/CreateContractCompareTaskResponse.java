// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class CreateContractCompareTaskResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateContractCompareTaskResponseBody body;

    public static CreateContractCompareTaskResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateContractCompareTaskResponse self = new CreateContractCompareTaskResponse();
        return TeaModel.build(map, self);
    }

    public CreateContractCompareTaskResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateContractCompareTaskResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateContractCompareTaskResponse setBody(CreateContractCompareTaskResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateContractCompareTaskResponseBody getBody() {
        return this.body;
    }

}
