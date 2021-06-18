// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class UpdateEmpAttrbuteVisibilitySettingResponseBody extends TeaModel {
    // settingId
    @NameInMap("result")
    public Long result;

    public static UpdateEmpAttrbuteVisibilitySettingResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateEmpAttrbuteVisibilitySettingResponseBody self = new UpdateEmpAttrbuteVisibilitySettingResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateEmpAttrbuteVisibilitySettingResponseBody setResult(Long result) {
        this.result = result;
        return this;
    }
    public Long getResult() {
        return this.result;
    }

}
