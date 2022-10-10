// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateStsTokenRequest extends TeaModel {
    // 设备sn码
    @NameInMap("deviceSn")
    public String deviceSn;

    // sts类型: oss/sls
    @NameInMap("stsType")
    public String stsType;

    public static CreateStsTokenRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateStsTokenRequest self = new CreateStsTokenRequest();
        return TeaModel.build(map, self);
    }

    public CreateStsTokenRequest setDeviceSn(String deviceSn) {
        this.deviceSn = deviceSn;
        return this;
    }
    public String getDeviceSn() {
        return this.deviceSn;
    }

    public CreateStsTokenRequest setStsType(String stsType) {
        this.stsType = stsType;
        return this;
    }
    public String getStsType() {
        return this.stsType;
    }

}
