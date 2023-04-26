// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class DeleteRecycleItemResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static DeleteRecycleItemResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteRecycleItemResponseBody self = new DeleteRecycleItemResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteRecycleItemResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
