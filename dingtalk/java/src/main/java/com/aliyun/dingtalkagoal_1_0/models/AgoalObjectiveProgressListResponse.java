// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class AgoalObjectiveProgressListResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AgoalObjectiveProgressListResponseBody body;

    public static AgoalObjectiveProgressListResponse build(java.util.Map<String, ?> map) throws Exception {
        AgoalObjectiveProgressListResponse self = new AgoalObjectiveProgressListResponse();
        return TeaModel.build(map, self);
    }

    public AgoalObjectiveProgressListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AgoalObjectiveProgressListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AgoalObjectiveProgressListResponse setBody(AgoalObjectiveProgressListResponseBody body) {
        this.body = body;
        return this;
    }
    public AgoalObjectiveProgressListResponseBody getBody() {
        return this.body;
    }

}
