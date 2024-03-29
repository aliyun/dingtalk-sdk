// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class DeleteTeacherResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DeleteTeacherResponseBody body;

    public static DeleteTeacherResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteTeacherResponse self = new DeleteTeacherResponse();
        return TeaModel.build(map, self);
    }

    public DeleteTeacherResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteTeacherResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeleteTeacherResponse setBody(DeleteTeacherResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteTeacherResponseBody getBody() {
        return this.body;
    }

}
