// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconnector_1_0.models;

import com.aliyun.tea.*;

public class SearchActionsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public SearchActionsResponseBody body;

    public static SearchActionsResponse build(java.util.Map<String, ?> map) throws Exception {
        SearchActionsResponse self = new SearchActionsResponse();
        return TeaModel.build(map, self);
    }

    public SearchActionsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SearchActionsResponse setBody(SearchActionsResponseBody body) {
        this.body = body;
        return this;
    }
    public SearchActionsResponseBody getBody() {
        return this.body;
    }

}
