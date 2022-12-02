// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksns_storage_1_0.models;

import com.aliyun.tea.*;

public class UnsubscribeEventResponseBody extends TeaModel {
    // 本次操作是否成功
    @NameInMap("success")
    public Boolean success;

    public static UnsubscribeEventResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UnsubscribeEventResponseBody self = new UnsubscribeEventResponseBody();
        return TeaModel.build(map, self);
    }

    public UnsubscribeEventResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
