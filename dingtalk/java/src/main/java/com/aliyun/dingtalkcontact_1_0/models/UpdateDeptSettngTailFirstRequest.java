// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class UpdateDeptSettngTailFirstRequest extends TeaModel {
    @NameInMap("enable")
    public Boolean enable;

    public static UpdateDeptSettngTailFirstRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateDeptSettngTailFirstRequest self = new UpdateDeptSettngTailFirstRequest();
        return TeaModel.build(map, self);
    }

    public UpdateDeptSettngTailFirstRequest setEnable(Boolean enable) {
        this.enable = enable;
        return this;
    }
    public Boolean getEnable() {
        return this.enable;
    }

}
