// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class InsertRowsBeforeResponseBody extends TeaModel {
    @NameInMap("id")
    public String id;

    public static InsertRowsBeforeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        InsertRowsBeforeResponseBody self = new InsertRowsBeforeResponseBody();
        return TeaModel.build(map, self);
    }

    public InsertRowsBeforeResponseBody setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

}
