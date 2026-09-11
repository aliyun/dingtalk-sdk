// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class DeptGroupSettingUpdateResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static DeptGroupSettingUpdateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeptGroupSettingUpdateResponseBody self = new DeptGroupSettingUpdateResponseBody();
        return TeaModel.build(map, self);
    }

    public DeptGroupSettingUpdateResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
