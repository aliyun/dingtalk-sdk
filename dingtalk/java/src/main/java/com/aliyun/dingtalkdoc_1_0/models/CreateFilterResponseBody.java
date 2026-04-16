// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class CreateFilterResponseBody extends TeaModel {
    @NameInMap("id")
    public String id;

    public static CreateFilterResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateFilterResponseBody self = new CreateFilterResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateFilterResponseBody setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

}
