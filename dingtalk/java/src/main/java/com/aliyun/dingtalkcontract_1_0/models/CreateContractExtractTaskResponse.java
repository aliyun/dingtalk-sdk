// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class CreateContractExtractTaskResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateContractExtractTaskResponseBody body;

    public static CreateContractExtractTaskResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateContractExtractTaskResponse self = new CreateContractExtractTaskResponse();
        return TeaModel.build(map, self);
    }

    public CreateContractExtractTaskResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateContractExtractTaskResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateContractExtractTaskResponse setBody(CreateContractExtractTaskResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateContractExtractTaskResponseBody getBody() {
        return this.body;
    }

}
