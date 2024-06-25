// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateStsTokenRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>fjke/12-131jk</p>
     */
    @NameInMap("deviceSn")
    public String deviceSn;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>sls</p>
     */
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
