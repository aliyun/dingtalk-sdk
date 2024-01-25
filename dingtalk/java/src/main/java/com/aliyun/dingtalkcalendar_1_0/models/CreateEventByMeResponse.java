// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class CreateEventByMeResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateEventByMeResponseBody body;

    public static CreateEventByMeResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateEventByMeResponse self = new CreateEventByMeResponse();
        return TeaModel.build(map, self);
    }

    public CreateEventByMeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateEventByMeResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateEventByMeResponse setBody(CreateEventByMeResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateEventByMeResponseBody getBody() {
        return this.body;
    }

}
