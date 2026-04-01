// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class DsbandOpenSceneGroupResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static DsbandOpenSceneGroupResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DsbandOpenSceneGroupResponseBody self = new DsbandOpenSceneGroupResponseBody();
        return TeaModel.build(map, self);
    }

    public DsbandOpenSceneGroupResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
