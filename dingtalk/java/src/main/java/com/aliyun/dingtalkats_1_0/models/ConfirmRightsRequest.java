// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class ConfirmRightsRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>ddats</p>
     */
    @NameInMap("bizCode")
    public String bizCode;

    public static ConfirmRightsRequest build(java.util.Map<String, ?> map) throws Exception {
        ConfirmRightsRequest self = new ConfirmRightsRequest();
        return TeaModel.build(map, self);
    }

    public ConfirmRightsRequest setBizCode(String bizCode) {
        this.bizCode = bizCode;
        return this;
    }
    public String getBizCode() {
        return this.bizCode;
    }

}
