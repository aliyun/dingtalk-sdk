// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class GetOrgRequest extends TeaModel {
    @NameInMap("unionId")
    public String unionId;

    public static GetOrgRequest build(java.util.Map<String, ?> map) throws Exception {
        GetOrgRequest self = new GetOrgRequest();
        return TeaModel.build(map, self);
    }

    public GetOrgRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
