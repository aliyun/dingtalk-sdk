// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdingmi_1_0.models;

import com.aliyun.tea.*;

public class PushCustomerGroupMessageResponseBody extends TeaModel {
    // 推送queryKey
    @NameInMap("result")
    public String result;

    public static PushCustomerGroupMessageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PushCustomerGroupMessageResponseBody self = new PushCustomerGroupMessageResponseBody();
        return TeaModel.build(map, self);
    }

    public PushCustomerGroupMessageResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

}
