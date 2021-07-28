// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class SetDeptPartnerTypeAndNumResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    public static SetDeptPartnerTypeAndNumResponse build(java.util.Map<String, ?> map) throws Exception {
        SetDeptPartnerTypeAndNumResponse self = new SetDeptPartnerTypeAndNumResponse();
        return TeaModel.build(map, self);
    }

    public SetDeptPartnerTypeAndNumResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

}
