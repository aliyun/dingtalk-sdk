// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class DeleteRecycleItemRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static DeleteRecycleItemRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteRecycleItemRequest self = new DeleteRecycleItemRequest();
        return TeaModel.build(map, self);
    }

    public DeleteRecycleItemRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
