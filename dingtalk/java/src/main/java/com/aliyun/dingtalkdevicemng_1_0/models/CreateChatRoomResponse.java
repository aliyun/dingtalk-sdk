// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class CreateChatRoomResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateChatRoomResponseBody body;

    public static CreateChatRoomResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateChatRoomResponse self = new CreateChatRoomResponse();
        return TeaModel.build(map, self);
    }

    public CreateChatRoomResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateChatRoomResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateChatRoomResponse setBody(CreateChatRoomResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateChatRoomResponseBody getBody() {
        return this.body;
    }

}
