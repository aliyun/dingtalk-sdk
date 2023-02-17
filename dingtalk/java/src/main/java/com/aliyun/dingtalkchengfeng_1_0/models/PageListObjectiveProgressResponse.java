// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class PageListObjectiveProgressResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public PageListObjectiveProgressResponseBody body;

    public static PageListObjectiveProgressResponse build(java.util.Map<String, ?> map) throws Exception {
        PageListObjectiveProgressResponse self = new PageListObjectiveProgressResponse();
        return TeaModel.build(map, self);
    }

    public PageListObjectiveProgressResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PageListObjectiveProgressResponse setBody(PageListObjectiveProgressResponseBody body) {
        this.body = body;
        return this;
    }
    public PageListObjectiveProgressResponseBody getBody() {
        return this.body;
    }

}
