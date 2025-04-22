// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class AddTraceEventResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AddTraceEventResponseBody body;

    public static AddTraceEventResponse build(java.util.Map<String, ?> map) throws Exception {
        AddTraceEventResponse self = new AddTraceEventResponse();
        return TeaModel.build(map, self);
    }

    public AddTraceEventResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddTraceEventResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AddTraceEventResponse setBody(AddTraceEventResponseBody body) {
        this.body = body;
        return this;
    }
    public AddTraceEventResponseBody getBody() {
        return this.body;
    }

}
