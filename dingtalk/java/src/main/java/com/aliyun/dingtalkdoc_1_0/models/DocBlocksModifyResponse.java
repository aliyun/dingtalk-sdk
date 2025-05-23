// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class DocBlocksModifyResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DocBlocksModifyResponseBody body;

    public static DocBlocksModifyResponse build(java.util.Map<String, ?> map) throws Exception {
        DocBlocksModifyResponse self = new DocBlocksModifyResponse();
        return TeaModel.build(map, self);
    }

    public DocBlocksModifyResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DocBlocksModifyResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DocBlocksModifyResponse setBody(DocBlocksModifyResponseBody body) {
        this.body = body;
        return this;
    }
    public DocBlocksModifyResponseBody getBody() {
        return this.body;
    }

}
