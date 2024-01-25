// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class DeleteUniversityCourseGroupResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DeleteUniversityCourseGroupResponseBody body;

    public static DeleteUniversityCourseGroupResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteUniversityCourseGroupResponse self = new DeleteUniversityCourseGroupResponse();
        return TeaModel.build(map, self);
    }

    public DeleteUniversityCourseGroupResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteUniversityCourseGroupResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeleteUniversityCourseGroupResponse setBody(DeleteUniversityCourseGroupResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteUniversityCourseGroupResponseBody getBody() {
        return this.body;
    }

}
