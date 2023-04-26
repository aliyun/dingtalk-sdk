// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class CreateDeviceChatRoomResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public CreateDeviceChatRoomResponseBody body;

    public static CreateDeviceChatRoomResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateDeviceChatRoomResponse self = new CreateDeviceChatRoomResponse();
        return TeaModel.build(map, self);
    }

    public CreateDeviceChatRoomResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateDeviceChatRoomResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateDeviceChatRoomResponse setBody(CreateDeviceChatRoomResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateDeviceChatRoomResponseBody getBody() {
        return this.body;
    }

}
