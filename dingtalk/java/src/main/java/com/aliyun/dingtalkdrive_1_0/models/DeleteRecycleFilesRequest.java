// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class DeleteRecycleFilesRequest extends TeaModel {
    // 回收站item id列表
    @NameInMap("recycleItemIdList")
    public java.util.List<Long> recycleItemIdList;

    // 回收站类型
    @NameInMap("recycleType")
    public String recycleType;

    public static DeleteRecycleFilesRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteRecycleFilesRequest self = new DeleteRecycleFilesRequest();
        return TeaModel.build(map, self);
    }

    public DeleteRecycleFilesRequest setRecycleItemIdList(java.util.List<Long> recycleItemIdList) {
        this.recycleItemIdList = recycleItemIdList;
        return this;
    }
    public java.util.List<Long> getRecycleItemIdList() {
        return this.recycleItemIdList;
    }

    public DeleteRecycleFilesRequest setRecycleType(String recycleType) {
        this.recycleType = recycleType;
        return this;
    }
    public String getRecycleType() {
        return this.recycleType;
    }

}
