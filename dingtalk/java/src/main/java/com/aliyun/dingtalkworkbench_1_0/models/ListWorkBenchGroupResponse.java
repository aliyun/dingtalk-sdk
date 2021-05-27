// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkbench_1_0.models;

import com.aliyun.tea.*;

public class ListWorkBenchGroupResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ListWorkBenchGroupResponseBody body;

    public static ListWorkBenchGroupResponse build(java.util.Map<String, ?> map) throws Exception {
        ListWorkBenchGroupResponse self = new ListWorkBenchGroupResponse();
        return TeaModel.build(map, self);
    }

    public ListWorkBenchGroupResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListWorkBenchGroupResponse setBody(ListWorkBenchGroupResponseBody body) {
        this.body = body;
        return this;
    }
    public ListWorkBenchGroupResponseBody getBody() {
        return this.body;
    }

}
