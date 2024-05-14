// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminiapp_1_0.models;

import com.aliyun.tea.*;

public class SetExtendSettingResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("result")
    public String result;

    public static SetExtendSettingResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SetExtendSettingResponseBody self = new SetExtendSettingResponseBody();
        return TeaModel.build(map, self);
    }

    public SetExtendSettingResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

}
