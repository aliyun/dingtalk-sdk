// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class GenerateCaldavAccountRequest extends TeaModel {
    @NameInMap("device")
    public String device;

    public static GenerateCaldavAccountRequest build(java.util.Map<String, ?> map) throws Exception {
        GenerateCaldavAccountRequest self = new GenerateCaldavAccountRequest();
        return TeaModel.build(map, self);
    }

    public GenerateCaldavAccountRequest setDevice(String device) {
        this.device = device;
        return this;
    }
    public String getDevice() {
        return this.device;
    }

}
