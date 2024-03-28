// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcool_app_1_0.models;

import com.aliyun.tea.*;

public class InstallCoolAppOrderToGroupResponseBody extends TeaModel {
    @NameInMap("result")
    public String result;

    @NameInMap("success")
    public Boolean success;

    public static InstallCoolAppOrderToGroupResponseBody build(java.util.Map<String, ?> map) throws Exception {
        InstallCoolAppOrderToGroupResponseBody self = new InstallCoolAppOrderToGroupResponseBody();
        return TeaModel.build(map, self);
    }

    public InstallCoolAppOrderToGroupResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

    public InstallCoolAppOrderToGroupResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
