// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class SearchTaskFlowResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public SearchTaskFlowResponseBody body;

    public static SearchTaskFlowResponse build(java.util.Map<String, ?> map) throws Exception {
        SearchTaskFlowResponse self = new SearchTaskFlowResponse();
        return TeaModel.build(map, self);
    }

    public SearchTaskFlowResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SearchTaskFlowResponse setBody(SearchTaskFlowResponseBody body) {
        this.body = body;
        return this;
    }
    public SearchTaskFlowResponseBody getBody() {
        return this.body;
    }

}
