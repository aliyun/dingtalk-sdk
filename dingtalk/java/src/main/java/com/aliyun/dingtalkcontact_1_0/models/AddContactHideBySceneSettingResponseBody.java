// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class AddContactHideBySceneSettingResponseBody extends TeaModel {
    @NameInMap("settingId")
    public Long settingId;

    public static AddContactHideBySceneSettingResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddContactHideBySceneSettingResponseBody self = new AddContactHideBySceneSettingResponseBody();
        return TeaModel.build(map, self);
    }

    public AddContactHideBySceneSettingResponseBody setSettingId(Long settingId) {
        this.settingId = settingId;
        return this;
    }
    public Long getSettingId() {
        return this.settingId;
    }

}
