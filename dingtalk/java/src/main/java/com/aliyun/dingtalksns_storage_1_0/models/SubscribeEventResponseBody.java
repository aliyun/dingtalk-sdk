// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksns_storage_1_0.models;

import com.aliyun.tea.*;

public class SubscribeEventResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static SubscribeEventResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SubscribeEventResponseBody self = new SubscribeEventResponseBody();
        return TeaModel.build(map, self);
    }

    public SubscribeEventResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
