// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class DocDeleteBlockResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DocDeleteBlockResponseBody body;

    public static DocDeleteBlockResponse build(java.util.Map<String, ?> map) throws Exception {
        DocDeleteBlockResponse self = new DocDeleteBlockResponse();
        return TeaModel.build(map, self);
    }

    public DocDeleteBlockResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DocDeleteBlockResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DocDeleteBlockResponse setBody(DocDeleteBlockResponseBody body) {
        this.body = body;
        return this;
    }
    public DocDeleteBlockResponseBody getBody() {
        return this.body;
    }

}
