// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcustomer_1_0.models;

import com.aliyun.tea.*;

public class ProjectSetupResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static ProjectSetupResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ProjectSetupResponseBody self = new ProjectSetupResponseBody();
        return TeaModel.build(map, self);
    }

    public ProjectSetupResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
