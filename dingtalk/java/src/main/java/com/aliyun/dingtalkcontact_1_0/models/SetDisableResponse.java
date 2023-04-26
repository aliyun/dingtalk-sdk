// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class SetDisableResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public SetDisableResponseBody body;

    public static SetDisableResponse build(java.util.Map<String, ?> map) throws Exception {
        SetDisableResponse self = new SetDisableResponse();
        return TeaModel.build(map, self);
    }

    public SetDisableResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SetDisableResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SetDisableResponse setBody(SetDisableResponseBody body) {
        this.body = body;
        return this;
    }
    public SetDisableResponseBody getBody() {
        return this.body;
    }

}
