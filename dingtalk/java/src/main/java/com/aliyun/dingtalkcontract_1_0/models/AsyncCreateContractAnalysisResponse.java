// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class AsyncCreateContractAnalysisResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AsyncCreateContractAnalysisResponseBody body;

    public static AsyncCreateContractAnalysisResponse build(java.util.Map<String, ?> map) throws Exception {
        AsyncCreateContractAnalysisResponse self = new AsyncCreateContractAnalysisResponse();
        return TeaModel.build(map, self);
    }

    public AsyncCreateContractAnalysisResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AsyncCreateContractAnalysisResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AsyncCreateContractAnalysisResponse setBody(AsyncCreateContractAnalysisResponseBody body) {
        this.body = body;
        return this;
    }
    public AsyncCreateContractAnalysisResponseBody getBody() {
        return this.body;
    }

}
