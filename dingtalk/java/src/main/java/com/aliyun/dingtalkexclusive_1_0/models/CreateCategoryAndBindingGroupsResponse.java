// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class CreateCategoryAndBindingGroupsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateCategoryAndBindingGroupsResponseBody body;

    public static CreateCategoryAndBindingGroupsResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateCategoryAndBindingGroupsResponse self = new CreateCategoryAndBindingGroupsResponse();
        return TeaModel.build(map, self);
    }

    public CreateCategoryAndBindingGroupsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateCategoryAndBindingGroupsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateCategoryAndBindingGroupsResponse setBody(CreateCategoryAndBindingGroupsResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateCategoryAndBindingGroupsResponseBody getBody() {
        return this.body;
    }

}
