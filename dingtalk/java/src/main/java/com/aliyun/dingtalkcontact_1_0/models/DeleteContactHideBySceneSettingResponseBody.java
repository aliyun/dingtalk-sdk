// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class DeleteContactHideBySceneSettingResponseBody extends TeaModel {
    /**
     * <p>是否成功</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static DeleteContactHideBySceneSettingResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteContactHideBySceneSettingResponseBody self = new DeleteContactHideBySceneSettingResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteContactHideBySceneSettingResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
