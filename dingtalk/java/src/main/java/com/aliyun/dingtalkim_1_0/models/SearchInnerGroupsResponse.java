// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class SearchInnerGroupsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public SearchInnerGroupsResponseBody body;

    public static SearchInnerGroupsResponse build(java.util.Map<String, ?> map) throws Exception {
        SearchInnerGroupsResponse self = new SearchInnerGroupsResponse();
        return TeaModel.build(map, self);
    }

    public SearchInnerGroupsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SearchInnerGroupsResponse setBody(SearchInnerGroupsResponseBody body) {
        this.body = body;
        return this;
    }
    public SearchInnerGroupsResponseBody getBody() {
        return this.body;
    }

}
