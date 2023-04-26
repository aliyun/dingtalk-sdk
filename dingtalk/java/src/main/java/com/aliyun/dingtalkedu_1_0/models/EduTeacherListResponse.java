// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class EduTeacherListResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public EduTeacherListResponseBody body;

    public static EduTeacherListResponse build(java.util.Map<String, ?> map) throws Exception {
        EduTeacherListResponse self = new EduTeacherListResponse();
        return TeaModel.build(map, self);
    }

    public EduTeacherListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public EduTeacherListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public EduTeacherListResponse setBody(EduTeacherListResponseBody body) {
        this.body = body;
        return this;
    }
    public EduTeacherListResponseBody getBody() {
        return this.body;
    }

}
