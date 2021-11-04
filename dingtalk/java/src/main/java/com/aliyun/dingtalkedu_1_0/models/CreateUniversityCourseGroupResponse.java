// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateUniversityCourseGroupResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CreateUniversityCourseGroupResponseBody body;

    public static CreateUniversityCourseGroupResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateUniversityCourseGroupResponse self = new CreateUniversityCourseGroupResponse();
        return TeaModel.build(map, self);
    }

    public CreateUniversityCourseGroupResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateUniversityCourseGroupResponse setBody(CreateUniversityCourseGroupResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateUniversityCourseGroupResponseBody getBody() {
        return this.body;
    }

}
