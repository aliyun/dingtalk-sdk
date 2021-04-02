// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class CreateEventResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CreateEventResponseBody body;

    public static CreateEventResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateEventResponse self = new CreateEventResponse();
        return TeaModel.build(map, self);
    }

    public CreateEventResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateEventResponse setBody(CreateEventResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateEventResponseBody getBody() {
        return this.body;
    }

}
