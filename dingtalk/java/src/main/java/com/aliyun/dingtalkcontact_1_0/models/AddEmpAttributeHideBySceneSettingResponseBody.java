// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class AddEmpAttributeHideBySceneSettingResponseBody extends TeaModel {
    /**
     * <p>settingId</p>
     */
    @NameInMap("settingId")
    public Long settingId;

    public static AddEmpAttributeHideBySceneSettingResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddEmpAttributeHideBySceneSettingResponseBody self = new AddEmpAttributeHideBySceneSettingResponseBody();
        return TeaModel.build(map, self);
    }

    public AddEmpAttributeHideBySceneSettingResponseBody setSettingId(Long settingId) {
        this.settingId = settingId;
        return this;
    }
    public Long getSettingId() {
        return this.settingId;
    }

}
