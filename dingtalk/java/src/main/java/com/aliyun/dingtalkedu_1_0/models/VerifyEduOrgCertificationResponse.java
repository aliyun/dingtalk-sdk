// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class VerifyEduOrgCertificationResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public VerifyEduOrgCertificationResponseBody body;

    public static VerifyEduOrgCertificationResponse build(java.util.Map<String, ?> map) throws Exception {
        VerifyEduOrgCertificationResponse self = new VerifyEduOrgCertificationResponse();
        return TeaModel.build(map, self);
    }

    public VerifyEduOrgCertificationResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public VerifyEduOrgCertificationResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public VerifyEduOrgCertificationResponse setBody(VerifyEduOrgCertificationResponseBody body) {
        this.body = body;
        return this;
    }
    public VerifyEduOrgCertificationResponseBody getBody() {
        return this.body;
    }

}
