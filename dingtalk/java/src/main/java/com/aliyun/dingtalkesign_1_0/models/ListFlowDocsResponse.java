// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_1_0.models;

import com.aliyun.tea.*;

public class ListFlowDocsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListFlowDocsResponseBody body;

    public static ListFlowDocsResponse build(java.util.Map<String, ?> map) throws Exception {
        ListFlowDocsResponse self = new ListFlowDocsResponse();
        return TeaModel.build(map, self);
    }

    public ListFlowDocsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListFlowDocsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListFlowDocsResponse setBody(ListFlowDocsResponseBody body) {
        this.body = body;
        return this;
    }
    public ListFlowDocsResponseBody getBody() {
        return this.body;
    }

}
