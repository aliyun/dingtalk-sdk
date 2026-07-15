// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkaiot_1_0.models;

import com.aliyun.tea.*;

public class SetDevicePropertiesRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("body")
    public java.util.Map<String, ?> body;

    public static SetDevicePropertiesRequest build(java.util.Map<String, ?> map) throws Exception {
        SetDevicePropertiesRequest self = new SetDevicePropertiesRequest();
        return TeaModel.build(map, self);
    }

    public SetDevicePropertiesRequest setBody(java.util.Map<String, ?> body) {
        this.body = body;
        return this;
    }
    public java.util.Map<String, ?> getBody() {
        return this.body;
    }

}
