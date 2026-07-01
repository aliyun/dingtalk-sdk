// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksmart_device_1_0.models;

import com.aliyun.tea.*;

public class ATMDeviceWorkNotifyResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static ATMDeviceWorkNotifyResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ATMDeviceWorkNotifyResponseBody self = new ATMDeviceWorkNotifyResponseBody();
        return TeaModel.build(map, self);
    }

    public ATMDeviceWorkNotifyResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
