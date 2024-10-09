// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class ListByCodesRequest extends TeaModel {
    @NameInMap("body")
    public java.util.List<String> body;

    public static ListByCodesRequest build(java.util.Map<String, ?> map) throws Exception {
        ListByCodesRequest self = new ListByCodesRequest();
        return TeaModel.build(map, self);
    }

    public ListByCodesRequest setBody(java.util.List<String> body) {
        this.body = body;
        return this;
    }
    public java.util.List<String> getBody() {
        return this.body;
    }

}
