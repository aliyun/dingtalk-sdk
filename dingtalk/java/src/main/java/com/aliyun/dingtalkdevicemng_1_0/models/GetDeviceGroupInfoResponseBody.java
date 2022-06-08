// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class GetDeviceGroupInfoResponseBody extends TeaModel {
    @NameInMap("result")
    public String result;

    @NameInMap("success")
    public Boolean success;

    public static GetDeviceGroupInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetDeviceGroupInfoResponseBody self = new GetDeviceGroupInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetDeviceGroupInfoResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

    public GetDeviceGroupInfoResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
