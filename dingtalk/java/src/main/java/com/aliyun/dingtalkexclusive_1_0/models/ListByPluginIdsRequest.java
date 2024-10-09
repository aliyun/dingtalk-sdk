// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class ListByPluginIdsRequest extends TeaModel {
    @NameInMap("body")
    public java.util.List<String> body;

    public static ListByPluginIdsRequest build(java.util.Map<String, ?> map) throws Exception {
        ListByPluginIdsRequest self = new ListByPluginIdsRequest();
        return TeaModel.build(map, self);
    }

    public ListByPluginIdsRequest setBody(java.util.List<String> body) {
        this.body = body;
        return this;
    }
    public java.util.List<String> getBody() {
        return this.body;
    }

}
