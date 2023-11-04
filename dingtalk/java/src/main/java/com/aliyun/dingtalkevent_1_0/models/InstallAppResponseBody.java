// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkevent_1_0.models;

import com.aliyun.tea.*;

public class InstallAppResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static InstallAppResponseBody build(java.util.Map<String, ?> map) throws Exception {
        InstallAppResponseBody self = new InstallAppResponseBody();
        return TeaModel.build(map, self);
    }

    public InstallAppResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
