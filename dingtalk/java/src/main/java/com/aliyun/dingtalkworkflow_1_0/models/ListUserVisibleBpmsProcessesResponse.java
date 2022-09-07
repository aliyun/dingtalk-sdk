// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class ListUserVisibleBpmsProcessesResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ListUserVisibleBpmsProcessesResponseBody body;

    public static ListUserVisibleBpmsProcessesResponse build(java.util.Map<String, ?> map) throws Exception {
        ListUserVisibleBpmsProcessesResponse self = new ListUserVisibleBpmsProcessesResponse();
        return TeaModel.build(map, self);
    }

    public ListUserVisibleBpmsProcessesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListUserVisibleBpmsProcessesResponse setBody(ListUserVisibleBpmsProcessesResponseBody body) {
        this.body = body;
        return this;
    }
    public ListUserVisibleBpmsProcessesResponseBody getBody() {
        return this.body;
    }

}
