// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class SearchActivationCodeResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SearchActivationCodeResponseBody body;

    public static SearchActivationCodeResponse build(java.util.Map<String, ?> map) throws Exception {
        SearchActivationCodeResponse self = new SearchActivationCodeResponse();
        return TeaModel.build(map, self);
    }

    public SearchActivationCodeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SearchActivationCodeResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SearchActivationCodeResponse setBody(SearchActivationCodeResponseBody body) {
        this.body = body;
        return this;
    }
    public SearchActivationCodeResponseBody getBody() {
        return this.body;
    }

}
