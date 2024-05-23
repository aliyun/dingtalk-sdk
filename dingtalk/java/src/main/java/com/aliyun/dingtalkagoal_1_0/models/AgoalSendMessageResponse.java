// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class AgoalSendMessageResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AgoalSendMessageResponseBody body;

    public static AgoalSendMessageResponse build(java.util.Map<String, ?> map) throws Exception {
        AgoalSendMessageResponse self = new AgoalSendMessageResponse();
        return TeaModel.build(map, self);
    }

    public AgoalSendMessageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AgoalSendMessageResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AgoalSendMessageResponse setBody(AgoalSendMessageResponseBody body) {
        this.body = body;
        return this;
    }
    public AgoalSendMessageResponseBody getBody() {
        return this.body;
    }

}
