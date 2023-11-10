// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class AddOrgAccountOwnnessResponseBody extends TeaModel {
    @NameInMap("result")
    public Long result;

    public static AddOrgAccountOwnnessResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddOrgAccountOwnnessResponseBody self = new AddOrgAccountOwnnessResponseBody();
        return TeaModel.build(map, self);
    }

    public AddOrgAccountOwnnessResponseBody setResult(Long result) {
        this.result = result;
        return this;
    }
    public Long getResult() {
        return this.result;
    }

}
