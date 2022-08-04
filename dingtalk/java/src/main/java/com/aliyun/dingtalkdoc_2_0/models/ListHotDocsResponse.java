// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class ListHotDocsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ListHotDocsResponseBody body;

    public static ListHotDocsResponse build(java.util.Map<String, ?> map) throws Exception {
        ListHotDocsResponse self = new ListHotDocsResponse();
        return TeaModel.build(map, self);
    }

    public ListHotDocsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListHotDocsResponse setBody(ListHotDocsResponseBody body) {
        this.body = body;
        return this;
    }
    public ListHotDocsResponseBody getBody() {
        return this.body;
    }

}
