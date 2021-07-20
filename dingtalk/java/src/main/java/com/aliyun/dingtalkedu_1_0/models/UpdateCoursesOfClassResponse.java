// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class UpdateCoursesOfClassResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public UpdateCoursesOfClassResponse setBody(UpdateCoursesOfClassResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateCoursesOfClassResponseBody getBody() {
        return this.body;
    }

}
