// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class CreateGroupSetResponseBody extends TeaModel {
    // 群分组id
    @NameInMap("result")
    public String result;

    public static CreateGroupSetResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateGroupSetResponseBody self = new CreateGroupSetResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateGroupSetResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

}
