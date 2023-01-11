// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class DeleteColumnsResponseBody extends TeaModel {
    /**
     * <p>工作表ID</p>
     */
    @NameInMap("id")
    public String id;

    public static DeleteColumnsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteColumnsResponseBody self = new DeleteColumnsResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteColumnsResponseBody setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

}
