// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class DeleteFilterViewResponseBody extends TeaModel {
    @NameInMap("id")
    public String id;

    public static DeleteFilterViewResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteFilterViewResponseBody self = new DeleteFilterViewResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteFilterViewResponseBody setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

}
