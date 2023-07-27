// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_2_0.models;

import com.aliyun.tea.*;

public class GroupManagerDeviceMarketResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public GroupManagerDeviceMarketResponseBody body;

    public static GroupManagerDeviceMarketResponse build(java.util.Map<String, ?> map) throws Exception {
        GroupManagerDeviceMarketResponse self = new GroupManagerDeviceMarketResponse();
        return TeaModel.build(map, self);
    }

    public GroupManagerDeviceMarketResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GroupManagerDeviceMarketResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GroupManagerDeviceMarketResponse setBody(GroupManagerDeviceMarketResponseBody body) {
        this.body = body;
        return this;
    }
    public GroupManagerDeviceMarketResponseBody getBody() {
        return this.body;
    }

}
