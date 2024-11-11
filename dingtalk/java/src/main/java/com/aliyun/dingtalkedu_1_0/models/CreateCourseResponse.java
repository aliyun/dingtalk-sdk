// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateCourseResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateCourseResponseBody body;

    public static CreateCourseResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateCourseResponse self = new CreateCourseResponse();
        return TeaModel.build(map, self);
    }

    public CreateCourseResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateCourseResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateCourseResponse setBody(CreateCourseResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateCourseResponseBody getBody() {
        return this.body;
    }

}
