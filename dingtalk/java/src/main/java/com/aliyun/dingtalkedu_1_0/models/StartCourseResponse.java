// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class StartCourseResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public StartCourseResponseBody body;

    public static StartCourseResponse build(java.util.Map<String, ?> map) throws Exception {
        StartCourseResponse self = new StartCourseResponse();
        return TeaModel.build(map, self);
    }

    public StartCourseResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public StartCourseResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public StartCourseResponse setBody(StartCourseResponseBody body) {
        this.body = body;
        return this;
    }
    public StartCourseResponseBody getBody() {
        return this.body;
    }

}
