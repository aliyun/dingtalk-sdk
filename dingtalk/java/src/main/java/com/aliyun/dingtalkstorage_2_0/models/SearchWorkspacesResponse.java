// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_2_0.models;

import com.aliyun.tea.*;

public class SearchWorkspacesResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public SearchWorkspacesResponseBody body;

    public static SearchWorkspacesResponse build(java.util.Map<String, ?> map) throws Exception {
        SearchWorkspacesResponse self = new SearchWorkspacesResponse();
        return TeaModel.build(map, self);
    }

    public SearchWorkspacesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SearchWorkspacesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SearchWorkspacesResponse setBody(SearchWorkspacesResponseBody body) {
        this.body = body;
        return this;
    }
    public SearchWorkspacesResponseBody getBody() {
        return this.body;
    }

}
