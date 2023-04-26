// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateRemoteClassCourseResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public CreateRemoteClassCourseResponseBody body;

    public static CreateRemoteClassCourseResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateRemoteClassCourseResponse self = new CreateRemoteClassCourseResponse();
        return TeaModel.build(map, self);
    }

    public CreateRemoteClassCourseResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateRemoteClassCourseResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateRemoteClassCourseResponse setBody(CreateRemoteClassCourseResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateRemoteClassCourseResponseBody getBody() {
        return this.body;
    }

}
