// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkevent_1_0.models;

import com.aliyun.tea.*;

public class InstallCoolAppResponseBody extends TeaModel {
    @NameInMap("result")
    public String result;

    public static InstallCoolAppResponseBody build(java.util.Map<String, ?> map) throws Exception {
        InstallCoolAppResponseBody self = new InstallCoolAppResponseBody();
        return TeaModel.build(map, self);
    }

    public InstallCoolAppResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

}
