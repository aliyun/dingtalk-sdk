// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class DeleteDeviceRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("sn")
    public String sn;

    public static DeleteDeviceRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteDeviceRequest self = new DeleteDeviceRequest();
        return TeaModel.build(map, self);
    }

    public DeleteDeviceRequest setSn(String sn) {
        this.sn = sn;
        return this;
    }
    public String getSn() {
        return this.sn;
    }

}
