// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class TerminateInstanceResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    public static TerminateInstanceResponse build(java.util.Map<String, ?> map) throws Exception {
        TerminateInstanceResponse self = new TerminateInstanceResponse();
        return TeaModel.build(map, self);
    }

    public TerminateInstanceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

}
