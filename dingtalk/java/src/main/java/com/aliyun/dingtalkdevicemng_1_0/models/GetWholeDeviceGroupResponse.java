// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class GetWholeDeviceGroupResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetWholeDeviceGroupResponseBody body;

    public static GetWholeDeviceGroupResponse build(java.util.Map<String, ?> map) throws Exception {
        GetWholeDeviceGroupResponse self = new GetWholeDeviceGroupResponse();
        return TeaModel.build(map, self);
    }

    public GetWholeDeviceGroupResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetWholeDeviceGroupResponse setBody(GetWholeDeviceGroupResponseBody body) {
        this.body = body;
        return this;
    }
    public GetWholeDeviceGroupResponseBody getBody() {
        return this.body;
    }

}