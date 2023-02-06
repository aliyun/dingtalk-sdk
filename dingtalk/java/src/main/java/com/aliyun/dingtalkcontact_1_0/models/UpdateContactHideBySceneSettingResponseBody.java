// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class UpdateContactHideBySceneSettingResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static UpdateContactHideBySceneSettingResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateContactHideBySceneSettingResponseBody self = new UpdateContactHideBySceneSettingResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateContactHideBySceneSettingResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
