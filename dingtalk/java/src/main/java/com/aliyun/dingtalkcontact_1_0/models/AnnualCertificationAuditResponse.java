// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class AnnualCertificationAuditResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AnnualCertificationAuditResponseBody body;

    public static AnnualCertificationAuditResponse build(java.util.Map<String, ?> map) throws Exception {
        AnnualCertificationAuditResponse self = new AnnualCertificationAuditResponse();
        return TeaModel.build(map, self);
    }

    public AnnualCertificationAuditResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AnnualCertificationAuditResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AnnualCertificationAuditResponse setBody(AnnualCertificationAuditResponseBody body) {
        this.body = body;
        return this;
    }
    public AnnualCertificationAuditResponseBody getBody() {
        return this.body;
    }

}
