// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_activities_1_0.models;

import com.aliyun.tea.*;

public class SendLiveActivityResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SendLiveActivityResponseBody body;

    public static SendLiveActivityResponse build(java.util.Map<String, ?> map) throws Exception {
        SendLiveActivityResponse self = new SendLiveActivityResponse();
        return TeaModel.build(map, self);
    }

    public SendLiveActivityResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SendLiveActivityResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SendLiveActivityResponse setBody(SendLiveActivityResponseBody body) {
        this.body = body;
        return this;
    }
    public SendLiveActivityResponseBody getBody() {
        return this.body;
    }

}
