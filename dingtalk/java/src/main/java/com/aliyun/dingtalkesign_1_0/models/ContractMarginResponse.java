// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_1_0.models;

import com.aliyun.tea.*;

public class ContractMarginResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ContractMarginResponseBody body;

    public static ContractMarginResponse build(java.util.Map<String, ?> map) throws Exception {
        ContractMarginResponse self = new ContractMarginResponse();
        return TeaModel.build(map, self);
    }

    public ContractMarginResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ContractMarginResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ContractMarginResponse setBody(ContractMarginResponseBody body) {
        this.body = body;
        return this;
    }
    public ContractMarginResponseBody getBody() {
        return this.body;
    }

}
