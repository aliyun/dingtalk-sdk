// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class SetUserVersionToFreeResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SetUserVersionToFreeResponseBody body;

    public static SetUserVersionToFreeResponse build(java.util.Map<String, ?> map) throws Exception {
        SetUserVersionToFreeResponse self = new SetUserVersionToFreeResponse();
        return TeaModel.build(map, self);
    }

    public SetUserVersionToFreeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SetUserVersionToFreeResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SetUserVersionToFreeResponse setBody(SetUserVersionToFreeResponseBody body) {
        this.body = body;
        return this;
    }
    public SetUserVersionToFreeResponseBody getBody() {
        return this.body;
    }

}
