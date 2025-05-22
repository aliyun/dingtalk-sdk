// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class DocExportByDelegatedPermissionResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DocExportByDelegatedPermissionResponseBody body;

    public static DocExportByDelegatedPermissionResponse build(java.util.Map<String, ?> map) throws Exception {
        DocExportByDelegatedPermissionResponse self = new DocExportByDelegatedPermissionResponse();
        return TeaModel.build(map, self);
    }

    public DocExportByDelegatedPermissionResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DocExportByDelegatedPermissionResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DocExportByDelegatedPermissionResponse setBody(DocExportByDelegatedPermissionResponseBody body) {
        this.body = body;
        return this;
    }
    public DocExportByDelegatedPermissionResponseBody getBody() {
        return this.body;
    }

}
