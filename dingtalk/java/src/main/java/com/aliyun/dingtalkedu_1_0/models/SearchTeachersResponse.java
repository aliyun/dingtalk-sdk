// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class SearchTeachersResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public SearchTeachersResponseBody body;

    public static SearchTeachersResponse build(java.util.Map<String, ?> map) throws Exception {
        SearchTeachersResponse self = new SearchTeachersResponse();
        return TeaModel.build(map, self);
    }

    public SearchTeachersResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SearchTeachersResponse setBody(SearchTeachersResponseBody body) {
        this.body = body;
        return this;
    }
    public SearchTeachersResponseBody getBody() {
        return this.body;
    }

}
