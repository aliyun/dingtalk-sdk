// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class ListOrgTextEmotionResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public ListOrgTextEmotionResponseBody body;

    public static ListOrgTextEmotionResponse build(java.util.Map<String, ?> map) throws Exception {
        ListOrgTextEmotionResponse self = new ListOrgTextEmotionResponse();
        return TeaModel.build(map, self);
    }

    public ListOrgTextEmotionResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListOrgTextEmotionResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListOrgTextEmotionResponse setBody(ListOrgTextEmotionResponseBody body) {
        this.body = body;
        return this;
    }
    public ListOrgTextEmotionResponseBody getBody() {
        return this.body;
    }

}
