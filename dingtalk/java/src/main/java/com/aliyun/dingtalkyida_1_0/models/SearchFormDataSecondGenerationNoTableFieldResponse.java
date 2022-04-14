// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class SearchFormDataSecondGenerationNoTableFieldResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public SearchFormDataSecondGenerationNoTableFieldResponseBody body;

    public static SearchFormDataSecondGenerationNoTableFieldResponse build(java.util.Map<String, ?> map) throws Exception {
        SearchFormDataSecondGenerationNoTableFieldResponse self = new SearchFormDataSecondGenerationNoTableFieldResponse();
        return TeaModel.build(map, self);
    }

    public SearchFormDataSecondGenerationNoTableFieldResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SearchFormDataSecondGenerationNoTableFieldResponse setBody(SearchFormDataSecondGenerationNoTableFieldResponseBody body) {
        this.body = body;
        return this;
    }
    public SearchFormDataSecondGenerationNoTableFieldResponseBody getBody() {
        return this.body;
    }

}
