// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class AgoalObjectiveKeyActionListResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AgoalObjectiveKeyActionListResponseBody body;

    public static AgoalObjectiveKeyActionListResponse build(java.util.Map<String, ?> map) throws Exception {
        AgoalObjectiveKeyActionListResponse self = new AgoalObjectiveKeyActionListResponse();
        return TeaModel.build(map, self);
    }

    public AgoalObjectiveKeyActionListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AgoalObjectiveKeyActionListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AgoalObjectiveKeyActionListResponse setBody(AgoalObjectiveKeyActionListResponseBody body) {
        this.body = body;
        return this;
    }
    public AgoalObjectiveKeyActionListResponseBody getBody() {
        return this.body;
    }

}
