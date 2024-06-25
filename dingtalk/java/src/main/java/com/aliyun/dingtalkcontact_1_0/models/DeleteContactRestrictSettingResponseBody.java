// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class DeleteContactRestrictSettingResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("result")
    public Boolean result;

    public static DeleteContactRestrictSettingResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteContactRestrictSettingResponseBody self = new DeleteContactRestrictSettingResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteContactRestrictSettingResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
