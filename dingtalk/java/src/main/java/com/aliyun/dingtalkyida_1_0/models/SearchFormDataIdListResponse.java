// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class SearchFormDataIdListResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public SearchFormDataIdListResponseBody body;

    public static SearchFormDataIdListResponse build(java.util.Map<String, ?> map) throws Exception {
        SearchFormDataIdListResponse self = new SearchFormDataIdListResponse();
        return TeaModel.build(map, self);
    }

    public SearchFormDataIdListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SearchFormDataIdListResponse setBody(SearchFormDataIdListResponseBody body) {
        this.body = body;
        return this;
    }
    public SearchFormDataIdListResponseBody getBody() {
        return this.body;
    }

}
