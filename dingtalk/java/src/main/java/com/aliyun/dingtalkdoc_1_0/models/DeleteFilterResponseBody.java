// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class DeleteFilterResponseBody extends TeaModel {
    @NameInMap("id")
    public String id;

    public static DeleteFilterResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteFilterResponseBody self = new DeleteFilterResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteFilterResponseBody setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

}
