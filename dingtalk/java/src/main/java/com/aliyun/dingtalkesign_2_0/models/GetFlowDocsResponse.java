// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0.models;

import com.aliyun.tea.*;

public class GetFlowDocsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public GetFlowDocsResponse setBody(GetFlowDocsResponseBody body) {
        this.body = body;
        return this;
    }
    public GetFlowDocsResponseBody getBody() {
        return this.body;
    }

}
