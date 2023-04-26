// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class AddAppToWorkBenchGroupResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static AddAppToWorkBenchGroupResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddAppToWorkBenchGroupResponseBody self = new AddAppToWorkBenchGroupResponseBody();
        return TeaModel.build(map, self);
    }

    public AddAppToWorkBenchGroupResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
