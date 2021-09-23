// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class SearchActivationCodeResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public SearchActivationCodeResponse setBody(SearchActivationCodeResponseBody body) {
        this.body = body;
        return this;
    }
    public SearchActivationCodeResponseBody getBody() {
        return this.body;
    }

}
