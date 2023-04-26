// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class ClearRecycleFilesRequest extends TeaModel {
    @NameInMap("recycleType")
    public String recycleType;

    @NameInMap("unionId")
    public String unionId;

    public static ClearRecycleFilesRequest build(java.util.Map<String, ?> map) throws Exception {
        ClearRecycleFilesRequest self = new ClearRecycleFilesRequest();
        return TeaModel.build(map, self);
    }

    public ClearRecycleFilesRequest setRecycleType(String recycleType) {
        this.recycleType = recycleType;
        return this;
    }
    public String getRecycleType() {
        return this.recycleType;
    }

    public ClearRecycleFilesRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
