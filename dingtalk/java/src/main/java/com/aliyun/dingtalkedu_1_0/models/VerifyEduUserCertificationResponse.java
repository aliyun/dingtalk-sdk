// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class VerifyEduUserCertificationResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public VerifyEduUserCertificationResponseBody body;

    public static VerifyEduUserCertificationResponse build(java.util.Map<String, ?> map) throws Exception {
        VerifyEduUserCertificationResponse self = new VerifyEduUserCertificationResponse();
        return TeaModel.build(map, self);
    }

    public VerifyEduUserCertificationResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public VerifyEduUserCertificationResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public VerifyEduUserCertificationResponse setBody(VerifyEduUserCertificationResponseBody body) {
        this.body = body;
        return this;
    }
    public VerifyEduUserCertificationResponseBody getBody() {
        return this.body;
    }

}
