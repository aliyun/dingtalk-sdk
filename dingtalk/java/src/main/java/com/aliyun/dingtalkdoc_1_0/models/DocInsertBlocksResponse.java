// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class DocInsertBlocksResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public DocInsertBlocksResponseBody body;

    public static DocInsertBlocksResponse build(java.util.Map<String, ?> map) throws Exception {
        DocInsertBlocksResponse self = new DocInsertBlocksResponse();
        return TeaModel.build(map, self);
    }

    public DocInsertBlocksResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DocInsertBlocksResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DocInsertBlocksResponse setBody(DocInsertBlocksResponseBody body) {
        this.body = body;
        return this;
    }
    public DocInsertBlocksResponseBody getBody() {
        return this.body;
    }

}
