// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class SearchUserTaskResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public SearchUserTaskResponseBody body;

    public static SearchUserTaskResponse build(java.util.Map<String, ?> map) throws Exception {
        SearchUserTaskResponse self = new SearchUserTaskResponse();
        return TeaModel.build(map, self);
    }

    public SearchUserTaskResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SearchUserTaskResponse setBody(SearchUserTaskResponseBody body) {
        this.body = body;
        return this;
    }
    public SearchUserTaskResponseBody getBody() {
        return this.body;
    }

}
