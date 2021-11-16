// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class SearchWorkspaceDocsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public SearchWorkspaceDocsResponse setBody(SearchWorkspaceDocsResponseBody body) {
        this.body = body;
        return this;
    }
    public SearchWorkspaceDocsResponseBody getBody() {
        return this.body;
    }

}
