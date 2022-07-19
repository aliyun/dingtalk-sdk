// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class GetSpaceRequest extends TeaModel {
    // 用户id
    @NameInMap("unionId")
    public String unionId;

    public static GetSpaceRequest build(java.util.Map<String, ?> map) throws Exception {
        GetSpaceRequest self = new GetSpaceRequest();
        return TeaModel.build(map, self);
    }

    public GetSpaceRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
