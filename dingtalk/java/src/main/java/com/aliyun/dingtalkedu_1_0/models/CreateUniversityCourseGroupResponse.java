// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateUniversityCourseGroupResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public CreateUniversityCourseGroupResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateUniversityCourseGroupResponse setBody(CreateUniversityCourseGroupResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateUniversityCourseGroupResponseBody getBody() {
        return this.body;
    }

}
