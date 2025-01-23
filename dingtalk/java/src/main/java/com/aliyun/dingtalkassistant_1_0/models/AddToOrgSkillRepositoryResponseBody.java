// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class AddToOrgSkillRepositoryResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static AddToOrgSkillRepositoryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddToOrgSkillRepositoryResponseBody self = new AddToOrgSkillRepositoryResponseBody();
        return TeaModel.build(map, self);
    }

    public AddToOrgSkillRepositoryResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
