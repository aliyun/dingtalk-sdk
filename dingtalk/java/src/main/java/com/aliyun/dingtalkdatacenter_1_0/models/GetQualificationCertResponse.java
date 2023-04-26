// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetQualificationCertResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public GetQualificationCertResponseBody body;

    public static GetQualificationCertResponse build(java.util.Map<String, ?> map) throws Exception {
        GetQualificationCertResponse self = new GetQualificationCertResponse();
        return TeaModel.build(map, self);
    }

    public GetQualificationCertResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetQualificationCertResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetQualificationCertResponse setBody(GetQualificationCertResponseBody body) {
        this.body = body;
        return this;
    }
    public GetQualificationCertResponseBody getBody() {
        return this.body;
    }

}
