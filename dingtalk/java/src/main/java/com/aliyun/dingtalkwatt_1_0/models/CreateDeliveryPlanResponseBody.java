// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkwatt_1_0.models;

import com.aliyun.tea.*;

public class CreateDeliveryPlanResponseBody extends TeaModel {
    @NameInMap("arguments")
    public java.util.List<?> arguments;

    @NameInMap("success")
    public Boolean success;

    public static CreateDeliveryPlanResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateDeliveryPlanResponseBody self = new CreateDeliveryPlanResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateDeliveryPlanResponseBody setArguments(java.util.List<?> arguments) {
        this.arguments = arguments;
        return this;
    }
    public java.util.List<?> getArguments() {
        return this.arguments;
    }

    public CreateDeliveryPlanResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
