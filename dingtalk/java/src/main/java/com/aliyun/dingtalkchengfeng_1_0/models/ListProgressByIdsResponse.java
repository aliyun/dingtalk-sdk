// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class ListProgressByIdsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ListProgressByIdsResponseBody body;

    public static ListProgressByIdsResponse build(java.util.Map<String, ?> map) throws Exception {
        ListProgressByIdsResponse self = new ListProgressByIdsResponse();
        return TeaModel.build(map, self);
    }

    public ListProgressByIdsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListProgressByIdsResponse setBody(ListProgressByIdsResponseBody body) {
        this.body = body;
        return this;
    }
    public ListProgressByIdsResponseBody getBody() {
        return this.body;
    }

}
