// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class GetImportDocumentMarkResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetImportDocumentMarkResponseBody body;

    public static GetImportDocumentMarkResponse build(java.util.Map<String, ?> map) throws Exception {
        GetImportDocumentMarkResponse self = new GetImportDocumentMarkResponse();
        return TeaModel.build(map, self);
    }

    public GetImportDocumentMarkResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetImportDocumentMarkResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetImportDocumentMarkResponse setBody(GetImportDocumentMarkResponseBody body) {
        this.body = body;
        return this;
    }
    public GetImportDocumentMarkResponseBody getBody() {
        return this.body;
    }

}
