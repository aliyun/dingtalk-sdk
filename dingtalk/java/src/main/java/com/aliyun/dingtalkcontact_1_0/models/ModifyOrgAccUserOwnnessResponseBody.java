// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class ModifyOrgAccUserOwnnessResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static ModifyOrgAccUserOwnnessResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ModifyOrgAccUserOwnnessResponseBody self = new ModifyOrgAccUserOwnnessResponseBody();
        return TeaModel.build(map, self);
    }

    public ModifyOrgAccUserOwnnessResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
