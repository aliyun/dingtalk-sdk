// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class UpdateFilterResponseBody extends TeaModel {
    @NameInMap("id")
    public String id;

    public static UpdateFilterResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateFilterResponseBody self = new UpdateFilterResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateFilterResponseBody setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

}
