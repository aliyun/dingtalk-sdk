// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class UpdateCoursesOfClassResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateCoursesOfClassResponseBody body;

    public static UpdateCoursesOfClassResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateCoursesOfClassResponse self = new UpdateCoursesOfClassResponse();
        return TeaModel.build(map, self);
    }

    public UpdateCoursesOfClassResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateCoursesOfClassResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateCoursesOfClassResponse setBody(UpdateCoursesOfClassResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateCoursesOfClassResponseBody getBody() {
        return this.body;
    }

}
