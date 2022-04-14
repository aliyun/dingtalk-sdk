// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class SearchFormDataRemovalTableDataResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public SearchFormDataRemovalTableDataResponseBody body;

    public static SearchFormDataRemovalTableDataResponse build(java.util.Map<String, ?> map) throws Exception {
        SearchFormDataRemovalTableDataResponse self = new SearchFormDataRemovalTableDataResponse();
        return TeaModel.build(map, self);
    }

    public SearchFormDataRemovalTableDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SearchFormDataRemovalTableDataResponse setBody(SearchFormDataRemovalTableDataResponseBody body) {
        this.body = body;
        return this;
    }
    public SearchFormDataRemovalTableDataResponseBody getBody() {
        return this.body;
    }

}
