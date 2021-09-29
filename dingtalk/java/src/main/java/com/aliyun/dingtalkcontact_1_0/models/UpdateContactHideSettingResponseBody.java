// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class UpdateContactHideSettingResponseBody extends TeaModel {
    // settingId
    @NameInMap("result")
    public Long result;

    public static UpdateContactHideSettingResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateContactHideSettingResponseBody self = new UpdateContactHideSettingResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateContactHideSettingResponseBody setResult(Long result) {
        this.result = result;
        return this;
    }
    public Long getResult() {
        return this.result;
    }

}
