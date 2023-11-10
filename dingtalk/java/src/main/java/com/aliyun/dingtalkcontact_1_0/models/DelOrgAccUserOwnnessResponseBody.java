// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class DelOrgAccUserOwnnessResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static DelOrgAccUserOwnnessResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DelOrgAccUserOwnnessResponseBody self = new DelOrgAccUserOwnnessResponseBody();
        return TeaModel.build(map, self);
    }

    public DelOrgAccUserOwnnessResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
