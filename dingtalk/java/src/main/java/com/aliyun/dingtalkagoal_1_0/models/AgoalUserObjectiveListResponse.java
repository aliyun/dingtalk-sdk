// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class AgoalUserObjectiveListResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AgoalUserObjectiveListResponseBody body;

    public static AgoalUserObjectiveListResponse build(java.util.Map<String, ?> map) throws Exception {
        AgoalUserObjectiveListResponse self = new AgoalUserObjectiveListResponse();
        return TeaModel.build(map, self);
    }

    public AgoalUserObjectiveListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AgoalUserObjectiveListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AgoalUserObjectiveListResponse setBody(AgoalUserObjectiveListResponseBody body) {
        this.body = body;
        return this;
    }
    public AgoalUserObjectiveListResponseBody getBody() {
        return this.body;
    }

}
