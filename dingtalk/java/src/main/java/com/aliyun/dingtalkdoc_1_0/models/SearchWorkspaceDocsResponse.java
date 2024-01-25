// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class SearchWorkspaceDocsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SearchWorkspaceDocsResponseBody body;

    public static SearchWorkspaceDocsResponse build(java.util.Map<String, ?> map) throws Exception {
        SearchWorkspaceDocsResponse self = new SearchWorkspaceDocsResponse();
        return TeaModel.build(map, self);
    }

    public SearchWorkspaceDocsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SearchWorkspaceDocsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SearchWorkspaceDocsResponse setBody(SearchWorkspaceDocsResponseBody body) {
        this.body = body;
        return this;
    }
    public SearchWorkspaceDocsResponseBody getBody() {
        return this.body;
    }

}
