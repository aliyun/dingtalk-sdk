// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class CreateSmartDeviceAiSummaryResponseBody extends TeaModel {
    @NameInMap("async")
    public Boolean async;

    public static CreateSmartDeviceAiSummaryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateSmartDeviceAiSummaryResponseBody self = new CreateSmartDeviceAiSummaryResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateSmartDeviceAiSummaryResponseBody setAsync(Boolean async) {
        this.async = async;
        return this;
    }
    public Boolean getAsync() {
        return this.async;
    }

}
