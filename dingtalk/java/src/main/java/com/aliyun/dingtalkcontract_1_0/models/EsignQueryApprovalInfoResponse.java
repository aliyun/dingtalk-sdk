// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class EsignQueryApprovalInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public EsignQueryApprovalInfoResponseBody body;

    public static EsignQueryApprovalInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        EsignQueryApprovalInfoResponse self = new EsignQueryApprovalInfoResponse();
        return TeaModel.build(map, self);
    }

    public EsignQueryApprovalInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public EsignQueryApprovalInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public EsignQueryApprovalInfoResponse setBody(EsignQueryApprovalInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public EsignQueryApprovalInfoResponseBody getBody() {
        return this.body;
    }

}
