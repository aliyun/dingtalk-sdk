// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class CreateTeamResponseBody extends TeaModel {
    @NameInMap("result")
    public String result;

    public static CreateTeamResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateTeamResponseBody self = new CreateTeamResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateTeamResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

}
