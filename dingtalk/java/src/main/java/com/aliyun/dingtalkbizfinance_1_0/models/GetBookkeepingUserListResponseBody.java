// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class GetBookkeepingUserListResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<String> result;

    public static GetBookkeepingUserListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetBookkeepingUserListResponseBody self = new GetBookkeepingUserListResponseBody();
        return TeaModel.build(map, self);
    }

    public GetBookkeepingUserListResponseBody setResult(java.util.List<String> result) {
        this.result = result;
        return this;
    }
    public java.util.List<String> getResult() {
        return this.result;
    }

}
