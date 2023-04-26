// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class DeleteRecycleFilesRequest extends TeaModel {
    @NameInMap("recycleItemIdList")
    public java.util.List<Long> recycleItemIdList;

    @NameInMap("recycleType")
    public String recycleType;

    @NameInMap("unionId")
    public String unionId;

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

    public DeleteRecycleFilesRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
