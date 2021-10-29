// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateRemoteClassCourseResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

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

    public CreateRemoteClassCourseResponse setBody(CreateRemoteClassCourseResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateRemoteClassCourseResponseBody getBody() {
        return this.body;
    }

}
