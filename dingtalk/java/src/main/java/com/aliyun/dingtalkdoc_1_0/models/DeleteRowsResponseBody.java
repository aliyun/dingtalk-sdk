// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class DeleteRowsResponseBody extends TeaModel {
    /**
     * <p>工作表ID</p>
     */
    @NameInMap("id")
    public String id;

    public static DeleteRowsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteRowsResponseBody self = new DeleteRowsResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteRowsResponseBody setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

}
