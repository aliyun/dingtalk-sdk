// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkbench_1_0.models;

import com.aliyun.tea.*;

public class AddRecentUserAppListResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static AddRecentUserAppListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddRecentUserAppListResponseBody self = new AddRecentUserAppListResponseBody();
        return TeaModel.build(map, self);
    }

    public AddRecentUserAppListResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
