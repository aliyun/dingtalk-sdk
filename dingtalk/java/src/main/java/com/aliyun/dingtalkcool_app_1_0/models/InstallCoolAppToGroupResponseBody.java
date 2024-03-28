// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcool_app_1_0.models;

import com.aliyun.tea.*;

public class InstallCoolAppToGroupResponseBody extends TeaModel {
    @NameInMap("result")
    public String result;

    @NameInMap("success")
    public Boolean success;

    public static InstallCoolAppToGroupResponseBody build(java.util.Map<String, ?> map) throws Exception {
        InstallCoolAppToGroupResponseBody self = new InstallCoolAppToGroupResponseBody();
        return TeaModel.build(map, self);
    }

    public InstallCoolAppToGroupResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

    public InstallCoolAppToGroupResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
