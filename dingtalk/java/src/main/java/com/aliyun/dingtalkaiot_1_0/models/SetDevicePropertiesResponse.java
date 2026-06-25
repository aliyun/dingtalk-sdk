// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkaiot_1_0.models;

import com.aliyun.tea.*;

public class SetDevicePropertiesResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SetDevicePropertiesResponseBody body;

    public static SetDevicePropertiesResponse build(java.util.Map<String, ?> map) throws Exception {
        SetDevicePropertiesResponse self = new SetDevicePropertiesResponse();
        return TeaModel.build(map, self);
    }

    public SetDevicePropertiesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SetDevicePropertiesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SetDevicePropertiesResponse setBody(SetDevicePropertiesResponseBody body) {
        this.body = body;
        return this;
    }
    public SetDevicePropertiesResponseBody getBody() {
        return this.body;
    }

}
