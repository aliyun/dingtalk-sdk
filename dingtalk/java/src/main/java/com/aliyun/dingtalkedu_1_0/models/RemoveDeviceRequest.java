// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class RemoveDeviceRequest extends TeaModel {
    @NameInMap("merchantId")
    public String merchantId;

    @NameInMap("sn")
    public String sn;

    public static RemoveDeviceRequest build(java.util.Map<String, ?> map) throws Exception {
        RemoveDeviceRequest self = new RemoveDeviceRequest();
        return TeaModel.build(map, self);
    }

    public RemoveDeviceRequest setMerchantId(String merchantId) {
        this.merchantId = merchantId;
        return this;
    }
    public String getMerchantId() {
        return this.merchantId;
    }

    public RemoveDeviceRequest setSn(String sn) {
        this.sn = sn;
        return this;
    }
    public String getSn() {
        return this.sn;
    }

}
