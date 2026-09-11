// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class GetA1DeviceBindingRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("sn")
    public String sn;

    public static GetA1DeviceBindingRequest build(java.util.Map<String, ?> map) throws Exception {
        GetA1DeviceBindingRequest self = new GetA1DeviceBindingRequest();
        return TeaModel.build(map, self);
    }

    public GetA1DeviceBindingRequest setSn(String sn) {
        this.sn = sn;
        return this;
    }
    public String getSn() {
        return this.sn;
    }

}
