// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkaiot_1_0.models;

import com.aliyun.tea.*;

public class SetDevicePropertiesResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static SetDevicePropertiesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SetDevicePropertiesResponseBody self = new SetDevicePropertiesResponseBody();
        return TeaModel.build(map, self);
    }

    public SetDevicePropertiesResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
