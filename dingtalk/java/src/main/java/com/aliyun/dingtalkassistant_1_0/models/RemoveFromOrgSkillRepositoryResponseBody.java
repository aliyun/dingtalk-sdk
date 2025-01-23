// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class RemoveFromOrgSkillRepositoryResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static RemoveFromOrgSkillRepositoryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RemoveFromOrgSkillRepositoryResponseBody self = new RemoveFromOrgSkillRepositoryResponseBody();
        return TeaModel.build(map, self);
    }

    public RemoveFromOrgSkillRepositoryResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
