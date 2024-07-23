// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class PersonalSendCardMessageResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public PersonalSendCardMessageResponseBody body;

    public static PersonalSendCardMessageResponse build(java.util.Map<String, ?> map) throws Exception {
        PersonalSendCardMessageResponse self = new PersonalSendCardMessageResponse();
        return TeaModel.build(map, self);
    }

    public PersonalSendCardMessageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PersonalSendCardMessageResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PersonalSendCardMessageResponse setBody(PersonalSendCardMessageResponseBody body) {
        this.body = body;
        return this;
    }
    public PersonalSendCardMessageResponseBody getBody() {
        return this.body;
    }

}
