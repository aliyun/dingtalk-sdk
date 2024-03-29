// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class GetWholeDeviceGroupResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public GetWholeDeviceGroupResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetWholeDeviceGroupResponse setBody(GetWholeDeviceGroupResponseBody body) {
        this.body = body;
        return this;
    }
    public GetWholeDeviceGroupResponseBody getBody() {
        return this.body;
    }

}
