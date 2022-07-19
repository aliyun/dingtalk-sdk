// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class RestoreRecycleItemResponseBody extends TeaModel {
    // 本次操作是否成功
    @NameInMap("success")
    public Boolean success;

    public static RestoreRecycleItemResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RestoreRecycleItemResponseBody self = new RestoreRecycleItemResponseBody();
        return TeaModel.build(map, self);
    }

    public RestoreRecycleItemResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
