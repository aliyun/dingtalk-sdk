// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class CreateContractAppsExtractTaskResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateContractAppsExtractTaskResponseBody body;

    public static CreateContractAppsExtractTaskResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateContractAppsExtractTaskResponse self = new CreateContractAppsExtractTaskResponse();
        return TeaModel.build(map, self);
    }

    public CreateContractAppsExtractTaskResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateContractAppsExtractTaskResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateContractAppsExtractTaskResponse setBody(CreateContractAppsExtractTaskResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateContractAppsExtractTaskResponseBody getBody() {
        return this.body;
    }

}
