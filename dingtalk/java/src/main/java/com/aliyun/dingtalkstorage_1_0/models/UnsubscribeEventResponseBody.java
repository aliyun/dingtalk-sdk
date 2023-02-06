// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class UnsubscribeEventResponseBody extends TeaModel {
    /**
     * <p>本次操作是否成功</p>
     */
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
