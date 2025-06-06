// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class DocUpdateContentWithDelegatedPermissionResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DocUpdateContentWithDelegatedPermissionResponseBody body;

    public static DocUpdateContentWithDelegatedPermissionResponse build(java.util.Map<String, ?> map) throws Exception {
        DocUpdateContentWithDelegatedPermissionResponse self = new DocUpdateContentWithDelegatedPermissionResponse();
        return TeaModel.build(map, self);
    }

    public DocUpdateContentWithDelegatedPermissionResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DocUpdateContentWithDelegatedPermissionResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DocUpdateContentWithDelegatedPermissionResponse setBody(DocUpdateContentWithDelegatedPermissionResponseBody body) {
        this.body = body;
        return this;
    }
    public DocUpdateContentWithDelegatedPermissionResponseBody getBody() {
        return this.body;
    }

}
