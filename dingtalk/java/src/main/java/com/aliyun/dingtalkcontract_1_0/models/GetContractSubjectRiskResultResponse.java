// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class GetContractSubjectRiskResultResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetContractSubjectRiskResultResponseBody body;

    public static GetContractSubjectRiskResultResponse build(java.util.Map<String, ?> map) throws Exception {
        GetContractSubjectRiskResultResponse self = new GetContractSubjectRiskResultResponse();
        return TeaModel.build(map, self);
    }

    public GetContractSubjectRiskResultResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetContractSubjectRiskResultResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetContractSubjectRiskResultResponse setBody(GetContractSubjectRiskResultResponseBody body) {
        this.body = body;
        return this;
    }
    public GetContractSubjectRiskResultResponseBody getBody() {
        return this.body;
    }

}
