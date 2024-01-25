// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0.models;

import com.aliyun.tea.*;

public class GetFlowDocsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetFlowDocsResponseBody body;

    public static GetFlowDocsResponse build(java.util.Map<String, ?> map) throws Exception {
        GetFlowDocsResponse self = new GetFlowDocsResponse();
        return TeaModel.build(map, self);
    }

    public GetFlowDocsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetFlowDocsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetFlowDocsResponse setBody(GetFlowDocsResponseBody body) {
        this.body = body;
        return this;
    }
    public GetFlowDocsResponseBody getBody() {
        return this.body;
    }

}
