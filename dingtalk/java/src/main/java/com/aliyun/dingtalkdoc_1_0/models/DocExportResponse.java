// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class DocExportResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DocExportResponseBody body;

    public static DocExportResponse build(java.util.Map<String, ?> map) throws Exception {
        DocExportResponse self = new DocExportResponse();
        return TeaModel.build(map, self);
    }

    public DocExportResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DocExportResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DocExportResponse setBody(DocExportResponseBody body) {
        this.body = body;
        return this;
    }
    public DocExportResponseBody getBody() {
        return this.body;
    }

}
