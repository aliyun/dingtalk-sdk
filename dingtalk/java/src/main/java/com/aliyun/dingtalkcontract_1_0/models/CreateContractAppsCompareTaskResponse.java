// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class CreateContractAppsCompareTaskResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateContractAppsCompareTaskResponseBody body;

    public static CreateContractAppsCompareTaskResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateContractAppsCompareTaskResponse self = new CreateContractAppsCompareTaskResponse();
        return TeaModel.build(map, self);
    }

    public CreateContractAppsCompareTaskResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateContractAppsCompareTaskResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateContractAppsCompareTaskResponse setBody(CreateContractAppsCompareTaskResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateContractAppsCompareTaskResponseBody getBody() {
        return this.body;
    }

}
