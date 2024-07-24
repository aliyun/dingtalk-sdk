// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class UpdateUnfurlingRegisterStatusResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateUnfurlingRegisterStatusResponseBody body;

    public static UpdateUnfurlingRegisterStatusResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateUnfurlingRegisterStatusResponse self = new UpdateUnfurlingRegisterStatusResponse();
        return TeaModel.build(map, self);
    }

    public UpdateUnfurlingRegisterStatusResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateUnfurlingRegisterStatusResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateUnfurlingRegisterStatusResponse setBody(UpdateUnfurlingRegisterStatusResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateUnfurlingRegisterStatusResponseBody getBody() {
        return this.body;
    }

}
