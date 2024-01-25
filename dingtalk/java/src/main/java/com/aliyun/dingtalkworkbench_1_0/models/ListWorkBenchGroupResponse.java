// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkbench_1_0.models;

import com.aliyun.tea.*;

public class ListWorkBenchGroupResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public ListWorkBenchGroupResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListWorkBenchGroupResponse setBody(ListWorkBenchGroupResponseBody body) {
        this.body = body;
        return this;
    }
    public ListWorkBenchGroupResponseBody getBody() {
        return this.body;
    }

}
