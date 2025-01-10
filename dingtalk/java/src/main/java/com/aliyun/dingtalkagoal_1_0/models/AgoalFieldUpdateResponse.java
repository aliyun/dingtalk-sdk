// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class AgoalFieldUpdateResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AgoalFieldUpdateResponseBody body;

    public static AgoalFieldUpdateResponse build(java.util.Map<String, ?> map) throws Exception {
        AgoalFieldUpdateResponse self = new AgoalFieldUpdateResponse();
        return TeaModel.build(map, self);
    }

    public AgoalFieldUpdateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AgoalFieldUpdateResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AgoalFieldUpdateResponse setBody(AgoalFieldUpdateResponseBody body) {
        this.body = body;
        return this;
    }
    public AgoalFieldUpdateResponseBody getBody() {
        return this.body;
    }

}
