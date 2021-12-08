// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class DeleteUniversityTeacherResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public DeleteUniversityTeacherResponseBody body;

    public static DeleteUniversityTeacherResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteUniversityTeacherResponse self = new DeleteUniversityTeacherResponse();
        return TeaModel.build(map, self);
    }

    public DeleteUniversityTeacherResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteUniversityTeacherResponse setBody(DeleteUniversityTeacherResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteUniversityTeacherResponseBody getBody() {
        return this.body;
    }

}
