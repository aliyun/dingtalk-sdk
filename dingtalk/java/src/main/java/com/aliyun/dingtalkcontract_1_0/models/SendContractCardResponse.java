// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class SendContractCardResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public SendContractCardResponseBody body;

    public static SendContractCardResponse build(java.util.Map<String, ?> map) throws Exception {
        SendContractCardResponse self = new SendContractCardResponse();
        return TeaModel.build(map, self);
    }

    public SendContractCardResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SendContractCardResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SendContractCardResponse setBody(SendContractCardResponseBody body) {
        this.body = body;
        return this;
    }
    public SendContractCardResponseBody getBody() {
        return this.body;
    }

}
