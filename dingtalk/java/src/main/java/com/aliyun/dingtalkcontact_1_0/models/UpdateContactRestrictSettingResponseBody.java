// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class UpdateContactRestrictSettingResponseBody extends TeaModel {
    @NameInMap("result")
    public Long result;

    public static UpdateContactRestrictSettingResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateContactRestrictSettingResponseBody self = new UpdateContactRestrictSettingResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateContactRestrictSettingResponseBody setResult(Long result) {
        this.result = result;
        return this;
    }
    public Long getResult() {
        return this.result;
    }

}
