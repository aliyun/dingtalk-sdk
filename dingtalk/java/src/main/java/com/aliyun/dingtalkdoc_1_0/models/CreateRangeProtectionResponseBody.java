// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class CreateRangeProtectionResponseBody extends TeaModel {
    @NameInMap("id")
    public String id;

    public static CreateRangeProtectionResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateRangeProtectionResponseBody self = new CreateRangeProtectionResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateRangeProtectionResponseBody setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

}
