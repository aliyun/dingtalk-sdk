// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class InvalidTeacherCourseResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public InvalidTeacherCourseResponseBody body;

    public static InvalidTeacherCourseResponse build(java.util.Map<String, ?> map) throws Exception {
        InvalidTeacherCourseResponse self = new InvalidTeacherCourseResponse();
        return TeaModel.build(map, self);
    }

    public InvalidTeacherCourseResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public InvalidTeacherCourseResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public InvalidTeacherCourseResponse setBody(InvalidTeacherCourseResponseBody body) {
        this.body = body;
        return this;
    }
    public InvalidTeacherCourseResponseBody getBody() {
        return this.body;
    }

}
