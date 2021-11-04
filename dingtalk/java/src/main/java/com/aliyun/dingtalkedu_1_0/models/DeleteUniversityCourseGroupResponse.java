// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class DeleteUniversityCourseGroupResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public DeleteUniversityCourseGroupResponse setBody(DeleteUniversityCourseGroupResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteUniversityCourseGroupResponseBody getBody() {
        return this.body;
    }

}
