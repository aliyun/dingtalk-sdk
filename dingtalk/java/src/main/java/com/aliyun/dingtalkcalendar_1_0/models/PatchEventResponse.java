// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class PatchEventResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public PatchEventResponseBody body;

    public static PatchEventResponse build(java.util.Map<String, ?> map) throws Exception {
        PatchEventResponse self = new PatchEventResponse();
        return TeaModel.build(map, self);
    }

    public PatchEventResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PatchEventResponse setBody(PatchEventResponseBody body) {
        this.body = body;
        return this;
    }
    public PatchEventResponseBody getBody() {
        return this.body;
    }

}
