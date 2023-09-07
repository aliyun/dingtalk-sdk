// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkwatt_1_0.models;

import com.aliyun.tea.*;

public class SendBannerResponseBody extends TeaModel {
    @NameInMap("arguments")
    public java.util.List<?> arguments;

    @NameInMap("success")
    public Boolean success;

    public static SendBannerResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SendBannerResponseBody self = new SendBannerResponseBody();
        return TeaModel.build(map, self);
    }

    public SendBannerResponseBody setArguments(java.util.List<?> arguments) {
        this.arguments = arguments;
        return this;
    }
    public java.util.List<?> getArguments() {
        return this.arguments;
    }

    public SendBannerResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
