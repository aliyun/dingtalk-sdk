// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetPrintAppInfoRequest extends TeaModel {
    // 搜索关键字
    @NameInMap("nameLike")
    public String nameLike;

    // 用户id
    @NameInMap("userId")
    public String userId;

    public static GetPrintAppInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        GetPrintAppInfoRequest self = new GetPrintAppInfoRequest();
        return TeaModel.build(map, self);
    }

    public GetPrintAppInfoRequest setNameLike(String nameLike) {
        this.nameLike = nameLike;
        return this;
    }
    public String getNameLike() {
        return this.nameLike;
    }

    public GetPrintAppInfoRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
