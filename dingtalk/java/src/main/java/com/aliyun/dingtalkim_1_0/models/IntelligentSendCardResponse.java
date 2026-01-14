// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class IntelligentSendCardResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public IntelligentSendCardResponseBody body;

    public static IntelligentSendCardResponse build(java.util.Map<String, ?> map) throws Exception {
        IntelligentSendCardResponse self = new IntelligentSendCardResponse();
        return TeaModel.build(map, self);
    }

    public IntelligentSendCardResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public IntelligentSendCardResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public IntelligentSendCardResponse setBody(IntelligentSendCardResponseBody body) {
        this.body = body;
        return this;
    }
    public IntelligentSendCardResponseBody getBody() {
        return this.body;
    }

}
