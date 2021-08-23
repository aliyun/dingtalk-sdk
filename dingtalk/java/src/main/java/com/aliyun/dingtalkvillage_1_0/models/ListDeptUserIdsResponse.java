// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class ListDeptUserIdsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ListDeptUserIdsResponseBody body;

    public static ListDeptUserIdsResponse build(java.util.Map<String, ?> map) throws Exception {
        ListDeptUserIdsResponse self = new ListDeptUserIdsResponse();
        return TeaModel.build(map, self);
    }

    public ListDeptUserIdsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListDeptUserIdsResponse setBody(ListDeptUserIdsResponseBody body) {
        this.body = body;
        return this;
    }
    public ListDeptUserIdsResponseBody getBody() {
        return this.body;
    }

}
