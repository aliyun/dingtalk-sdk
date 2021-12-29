// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class ListActivateDevicesResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ListActivateDevicesResponseBody body;

    public static ListActivateDevicesResponse build(java.util.Map<String, ?> map) throws Exception {
        ListActivateDevicesResponse self = new ListActivateDevicesResponse();
        return TeaModel.build(map, self);
    }

    public ListActivateDevicesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListActivateDevicesResponse setBody(ListActivateDevicesResponseBody body) {
        this.body = body;
        return this;
    }
    public ListActivateDevicesResponseBody getBody() {
        return this.body;
    }

}
