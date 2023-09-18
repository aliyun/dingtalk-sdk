// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class DocDeleteBlockResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
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
