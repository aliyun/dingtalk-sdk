// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_activities_1_0.models;

import com.aliyun.tea.*;

public class PushLiveActivityResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public PushLiveActivityResponseBody body;

    public static PushLiveActivityResponse build(java.util.Map<String, ?> map) throws Exception {
        PushLiveActivityResponse self = new PushLiveActivityResponse();
        return TeaModel.build(map, self);
    }

    public PushLiveActivityResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PushLiveActivityResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PushLiveActivityResponse setBody(PushLiveActivityResponseBody body) {
        this.body = body;
        return this;
    }
    public PushLiveActivityResponseBody getBody() {
        return this.body;
    }

}
