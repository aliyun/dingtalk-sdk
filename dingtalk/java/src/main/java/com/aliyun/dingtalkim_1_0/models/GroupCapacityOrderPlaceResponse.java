// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class GroupCapacityOrderPlaceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GroupCapacityOrderPlaceResponseBody body;

    public static GroupCapacityOrderPlaceResponse build(java.util.Map<String, ?> map) throws Exception {
        GroupCapacityOrderPlaceResponse self = new GroupCapacityOrderPlaceResponse();
        return TeaModel.build(map, self);
    }

    public GroupCapacityOrderPlaceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GroupCapacityOrderPlaceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GroupCapacityOrderPlaceResponse setBody(GroupCapacityOrderPlaceResponseBody body) {
        this.body = body;
        return this;
    }
    public GroupCapacityOrderPlaceResponseBody getBody() {
        return this.body;
    }

}
