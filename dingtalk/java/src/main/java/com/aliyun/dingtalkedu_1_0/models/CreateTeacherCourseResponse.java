// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateTeacherCourseResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateTeacherCourseResponseBody body;

    public static CreateTeacherCourseResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateTeacherCourseResponse self = new CreateTeacherCourseResponse();
        return TeaModel.build(map, self);
    }

    public CreateTeacherCourseResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateTeacherCourseResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateTeacherCourseResponse setBody(CreateTeacherCourseResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateTeacherCourseResponseBody getBody() {
        return this.body;
    }

}
