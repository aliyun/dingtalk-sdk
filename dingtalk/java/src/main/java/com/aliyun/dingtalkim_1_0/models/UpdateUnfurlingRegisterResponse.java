// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class UpdateUnfurlingRegisterResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateUnfurlingRegisterResponseBody body;

    public static UpdateUnfurlingRegisterResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateUnfurlingRegisterResponse self = new UpdateUnfurlingRegisterResponse();
        return TeaModel.build(map, self);
    }

    public UpdateUnfurlingRegisterResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateUnfurlingRegisterResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateUnfurlingRegisterResponse setBody(UpdateUnfurlingRegisterResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateUnfurlingRegisterResponseBody getBody() {
        return this.body;
    }

}
