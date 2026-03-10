// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class ControlRecordingResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ControlRecordingResponseBody body;

    public static ControlRecordingResponse build(java.util.Map<String, ?> map) throws Exception {
        ControlRecordingResponse self = new ControlRecordingResponse();
        return TeaModel.build(map, self);
    }

    public ControlRecordingResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ControlRecordingResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ControlRecordingResponse setBody(ControlRecordingResponseBody body) {
        this.body = body;
        return this;
    }
    public ControlRecordingResponseBody getBody() {
        return this.body;
    }

}
