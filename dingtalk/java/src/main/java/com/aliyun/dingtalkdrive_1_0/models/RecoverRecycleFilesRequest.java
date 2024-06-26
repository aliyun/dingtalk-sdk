// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class RecoverRecycleFilesRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("recycleItemIdList")
    public java.util.List<Long> recycleItemIdList;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("recycleType")
    public String recycleType;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static RecoverRecycleFilesRequest build(java.util.Map<String, ?> map) throws Exception {
        RecoverRecycleFilesRequest self = new RecoverRecycleFilesRequest();
        return TeaModel.build(map, self);
    }

    public RecoverRecycleFilesRequest setRecycleItemIdList(java.util.List<Long> recycleItemIdList) {
        this.recycleItemIdList = recycleItemIdList;
        return this;
    }
    public java.util.List<Long> getRecycleItemIdList() {
        return this.recycleItemIdList;
    }

    public RecoverRecycleFilesRequest setRecycleType(String recycleType) {
        this.recycleType = recycleType;
        return this;
    }
    public String getRecycleType() {
        return this.recycleType;
    }

    public RecoverRecycleFilesRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
