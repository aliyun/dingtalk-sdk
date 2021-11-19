// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class BoundTemplateToTeamResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static BoundTemplateToTeamResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BoundTemplateToTeamResponseBody self = new BoundTemplateToTeamResponseBody();
        return TeaModel.build(map, self);
    }

    public BoundTemplateToTeamResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
