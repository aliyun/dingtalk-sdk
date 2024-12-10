// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class DocSlotsQueryResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DocSlotsQueryResponseBody body;

    public static DocSlotsQueryResponse build(java.util.Map<String, ?> map) throws Exception {
        DocSlotsQueryResponse self = new DocSlotsQueryResponse();
        return TeaModel.build(map, self);
    }

    public DocSlotsQueryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DocSlotsQueryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DocSlotsQueryResponse setBody(DocSlotsQueryResponseBody body) {
        this.body = body;
        return this;
    }
    public DocSlotsQueryResponseBody getBody() {
        return this.body;
    }

}
