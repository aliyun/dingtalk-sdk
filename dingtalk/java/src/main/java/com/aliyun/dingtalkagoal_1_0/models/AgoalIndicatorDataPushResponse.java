// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class AgoalIndicatorDataPushResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AgoalIndicatorDataPushResponseBody body;

    public static AgoalIndicatorDataPushResponse build(java.util.Map<String, ?> map) throws Exception {
        AgoalIndicatorDataPushResponse self = new AgoalIndicatorDataPushResponse();
        return TeaModel.build(map, self);
    }

    public AgoalIndicatorDataPushResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AgoalIndicatorDataPushResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AgoalIndicatorDataPushResponse setBody(AgoalIndicatorDataPushResponseBody body) {
        this.body = body;
        return this;
    }
    public AgoalIndicatorDataPushResponseBody getBody() {
        return this.body;
    }

}
