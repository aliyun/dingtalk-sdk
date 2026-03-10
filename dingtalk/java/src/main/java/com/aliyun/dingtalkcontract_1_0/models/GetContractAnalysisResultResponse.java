// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class GetContractAnalysisResultResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetContractAnalysisResultResponseBody body;

    public static GetContractAnalysisResultResponse build(java.util.Map<String, ?> map) throws Exception {
        GetContractAnalysisResultResponse self = new GetContractAnalysisResultResponse();
        return TeaModel.build(map, self);
    }

    public GetContractAnalysisResultResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetContractAnalysisResultResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetContractAnalysisResultResponse setBody(GetContractAnalysisResultResponseBody body) {
        this.body = body;
        return this;
    }
    public GetContractAnalysisResultResponseBody getBody() {
        return this.body;
    }

}
