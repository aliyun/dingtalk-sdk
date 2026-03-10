// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class SubmitTripApprovalProcessResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SubmitTripApprovalProcessResponseBody body;

    public static SubmitTripApprovalProcessResponse build(java.util.Map<String, ?> map) throws Exception {
        SubmitTripApprovalProcessResponse self = new SubmitTripApprovalProcessResponse();
        return TeaModel.build(map, self);
    }

    public SubmitTripApprovalProcessResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SubmitTripApprovalProcessResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SubmitTripApprovalProcessResponse setBody(SubmitTripApprovalProcessResponseBody body) {
        this.body = body;
        return this;
    }
    public SubmitTripApprovalProcessResponseBody getBody() {
        return this.body;
    }

}
