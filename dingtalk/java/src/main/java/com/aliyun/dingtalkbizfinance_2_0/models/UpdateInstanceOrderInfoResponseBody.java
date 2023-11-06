// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class UpdateInstanceOrderInfoResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static UpdateInstanceOrderInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateInstanceOrderInfoResponseBody self = new UpdateInstanceOrderInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateInstanceOrderInfoResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
