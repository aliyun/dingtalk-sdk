// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class GroupCapacityInquiryResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public GroupCapacityInquiryResponseBody body;

    public static GroupCapacityInquiryResponse build(java.util.Map<String, ?> map) throws Exception {
        GroupCapacityInquiryResponse self = new GroupCapacityInquiryResponse();
        return TeaModel.build(map, self);
    }

    public GroupCapacityInquiryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GroupCapacityInquiryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GroupCapacityInquiryResponse setBody(GroupCapacityInquiryResponseBody body) {
        this.body = body;
        return this;
    }
    public GroupCapacityInquiryResponseBody getBody() {
        return this.body;
    }

}
