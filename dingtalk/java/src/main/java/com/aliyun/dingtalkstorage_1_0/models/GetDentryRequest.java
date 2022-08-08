// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class GetDentryRequest extends TeaModel {
    // 用户id
    @NameInMap("unionId")
    public String unionId;

    public static GetDentryRequest build(java.util.Map<String, ?> map) throws Exception {
        GetDentryRequest self = new GetDentryRequest();
        return TeaModel.build(map, self);
    }

    public GetDentryRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
