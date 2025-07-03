// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class SetSubtitleEventResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SetSubtitleEventResponseBody body;

    public static SetSubtitleEventResponse build(java.util.Map<String, ?> map) throws Exception {
        SetSubtitleEventResponse self = new SetSubtitleEventResponse();
        return TeaModel.build(map, self);
    }

    public SetSubtitleEventResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SetSubtitleEventResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SetSubtitleEventResponse setBody(SetSubtitleEventResponseBody body) {
        this.body = body;
        return this;
    }
    public SetSubtitleEventResponseBody getBody() {
        return this.body;
    }

}
