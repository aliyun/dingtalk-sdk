// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class SearchProjectCustomfieldResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public SearchProjectCustomfieldResponseBody body;

    public static SearchProjectCustomfieldResponse build(java.util.Map<String, ?> map) throws Exception {
        SearchProjectCustomfieldResponse self = new SearchProjectCustomfieldResponse();
        return TeaModel.build(map, self);
    }

    public SearchProjectCustomfieldResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SearchProjectCustomfieldResponse setBody(SearchProjectCustomfieldResponseBody body) {
        this.body = body;
        return this;
    }
    public SearchProjectCustomfieldResponseBody getBody() {
        return this.body;
    }

}
