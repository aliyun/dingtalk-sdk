// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class IsYuwenCertifiedTeacherResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public IsYuwenCertifiedTeacherResponseBody body;

    public static IsYuwenCertifiedTeacherResponse build(java.util.Map<String, ?> map) throws Exception {
        IsYuwenCertifiedTeacherResponse self = new IsYuwenCertifiedTeacherResponse();
        return TeaModel.build(map, self);
    }

    public IsYuwenCertifiedTeacherResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public IsYuwenCertifiedTeacherResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public IsYuwenCertifiedTeacherResponse setBody(IsYuwenCertifiedTeacherResponseBody body) {
        this.body = body;
        return this;
    }
    public IsYuwenCertifiedTeacherResponseBody getBody() {
        return this.body;
    }

}
