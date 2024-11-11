// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class InvalidCourseResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public InvalidCourseResponseBody body;

    public static InvalidCourseResponse build(java.util.Map<String, ?> map) throws Exception {
        InvalidCourseResponse self = new InvalidCourseResponse();
        return TeaModel.build(map, self);
    }

    public InvalidCourseResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public InvalidCourseResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public InvalidCourseResponse setBody(InvalidCourseResponseBody body) {
        this.body = body;
        return this;
    }
    public InvalidCourseResponseBody getBody() {
        return this.body;
    }

}
