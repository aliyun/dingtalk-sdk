// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class DeleteRecycleItemsResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static DeleteRecycleItemsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteRecycleItemsResponseBody self = new DeleteRecycleItemsResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteRecycleItemsResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
