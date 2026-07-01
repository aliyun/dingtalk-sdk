// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class UpdateTeamResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static UpdateTeamResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateTeamResponseBody self = new UpdateTeamResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateTeamResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
