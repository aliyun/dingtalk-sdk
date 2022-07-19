// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class DeleteRecycleItemsRequest extends TeaModel {
    // 回收项id列表
    @NameInMap("recycleItemIds")
    public java.util.List<String> recycleItemIds;

    // 用户id
    @NameInMap("unionId")
    public String unionId;

    public static DeleteRecycleItemsRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteRecycleItemsRequest self = new DeleteRecycleItemsRequest();
        return TeaModel.build(map, self);
    }

    public DeleteRecycleItemsRequest setRecycleItemIds(java.util.List<String> recycleItemIds) {
        this.recycleItemIds = recycleItemIds;
        return this;
    }
    public java.util.List<String> getRecycleItemIds() {
        return this.recycleItemIds;
    }

    public DeleteRecycleItemsRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
