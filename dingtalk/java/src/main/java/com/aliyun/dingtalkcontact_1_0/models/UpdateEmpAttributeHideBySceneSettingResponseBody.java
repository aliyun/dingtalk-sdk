// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class UpdateEmpAttributeHideBySceneSettingResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static UpdateEmpAttributeHideBySceneSettingResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateEmpAttributeHideBySceneSettingResponseBody self = new UpdateEmpAttributeHideBySceneSettingResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateEmpAttributeHideBySceneSettingResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
