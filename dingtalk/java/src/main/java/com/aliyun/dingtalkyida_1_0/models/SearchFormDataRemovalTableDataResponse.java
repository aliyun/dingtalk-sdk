// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class SearchFormDataRemovalTableDataResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public SearchFormDataRemovalTableDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SearchFormDataRemovalTableDataResponse setBody(SearchFormDataRemovalTableDataResponseBody body) {
        this.body = body;
        return this;
    }
    public SearchFormDataRemovalTableDataResponseBody getBody() {
        return this.body;
    }

}
