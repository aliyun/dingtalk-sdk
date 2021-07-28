// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class SearchUserResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public SearchUserResponseBody body;

    public static SearchUserResponse build(java.util.Map<String, ?> map) throws Exception {
        SearchUserResponse self = new SearchUserResponse();
        return TeaModel.build(map, self);
    }

    public SearchUserResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SearchUserResponse setBody(SearchUserResponseBody body) {
        this.body = body;
        return this;
    }
    public SearchUserResponseBody getBody() {
        return this.body;
    }

}
