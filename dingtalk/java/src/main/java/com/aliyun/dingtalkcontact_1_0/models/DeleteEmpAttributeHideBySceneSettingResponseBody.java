// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class DeleteEmpAttributeHideBySceneSettingResponseBody extends TeaModel {
    /**
     * <p>是否成功</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static DeleteEmpAttributeHideBySceneSettingResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteEmpAttributeHideBySceneSettingResponseBody self = new DeleteEmpAttributeHideBySceneSettingResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteEmpAttributeHideBySceneSettingResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
