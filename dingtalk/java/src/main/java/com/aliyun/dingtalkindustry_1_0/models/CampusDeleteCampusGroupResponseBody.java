// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CampusDeleteCampusGroupResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static CampusDeleteCampusGroupResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CampusDeleteCampusGroupResponseBody self = new CampusDeleteCampusGroupResponseBody();
        return TeaModel.build(map, self);
    }

    public CampusDeleteCampusGroupResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
