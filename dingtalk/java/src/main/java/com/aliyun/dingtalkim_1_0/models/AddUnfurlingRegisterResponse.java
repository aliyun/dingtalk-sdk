// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class AddUnfurlingRegisterResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AddUnfurlingRegisterResponseBody body;

    public static AddUnfurlingRegisterResponse build(java.util.Map<String, ?> map) throws Exception {
        AddUnfurlingRegisterResponse self = new AddUnfurlingRegisterResponse();
        return TeaModel.build(map, self);
    }

    public AddUnfurlingRegisterResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddUnfurlingRegisterResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AddUnfurlingRegisterResponse setBody(AddUnfurlingRegisterResponseBody body) {
        this.body = body;
        return this;
    }
    public AddUnfurlingRegisterResponseBody getBody() {
        return this.body;
    }

}
