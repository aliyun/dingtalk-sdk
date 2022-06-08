// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class GetWholeDeviceGroupResponseBody extends TeaModel {
    @NameInMap("result")
    public String result;

    @NameInMap("success")
    public Boolean success;

    public static GetWholeDeviceGroupResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetWholeDeviceGroupResponseBody self = new GetWholeDeviceGroupResponseBody();
        return TeaModel.build(map, self);
    }

    public GetWholeDeviceGroupResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

    public GetWholeDeviceGroupResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
