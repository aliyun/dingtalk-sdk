// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class EndCourseResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public EndCourseResponseBody body;

    public static EndCourseResponse build(java.util.Map<String, ?> map) throws Exception {
        EndCourseResponse self = new EndCourseResponse();
        return TeaModel.build(map, self);
    }

    public EndCourseResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public EndCourseResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public EndCourseResponse setBody(EndCourseResponseBody body) {
        this.body = body;
        return this;
    }
    public EndCourseResponseBody getBody() {
        return this.body;
    }

}
