// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class SetEnableResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SetEnableResponseBody body;

    public static SetEnableResponse build(java.util.Map<String, ?> map) throws Exception {
        SetEnableResponse self = new SetEnableResponse();
        return TeaModel.build(map, self);
    }

    public SetEnableResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SetEnableResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SetEnableResponse setBody(SetEnableResponseBody body) {
        this.body = body;
        return this;
    }
    public SetEnableResponseBody getBody() {
        return this.body;
    }

}
