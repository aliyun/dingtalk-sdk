// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class GetAsyncCreateContractAnalysisResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetAsyncCreateContractAnalysisResponseBody body;

    public static GetAsyncCreateContractAnalysisResponse build(java.util.Map<String, ?> map) throws Exception {
        GetAsyncCreateContractAnalysisResponse self = new GetAsyncCreateContractAnalysisResponse();
        return TeaModel.build(map, self);
    }

    public GetAsyncCreateContractAnalysisResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetAsyncCreateContractAnalysisResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetAsyncCreateContractAnalysisResponse setBody(GetAsyncCreateContractAnalysisResponseBody body) {
        this.body = body;
        return this;
    }
    public GetAsyncCreateContractAnalysisResponseBody getBody() {
        return this.body;
    }

}
