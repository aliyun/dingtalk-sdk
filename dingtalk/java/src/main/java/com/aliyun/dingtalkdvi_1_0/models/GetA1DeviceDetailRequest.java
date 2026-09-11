// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class GetA1DeviceDetailRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("sn")
    public String sn;

    public static GetA1DeviceDetailRequest build(java.util.Map<String, ?> map) throws Exception {
        GetA1DeviceDetailRequest self = new GetA1DeviceDetailRequest();
        return TeaModel.build(map, self);
    }

    public GetA1DeviceDetailRequest setSn(String sn) {
        this.sn = sn;
        return this;
    }
    public String getSn() {
        return this.sn;
    }

}
