// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class SetRowsVisibilityResponseBody extends TeaModel {
    /**
     * <p>工作表id</p>
     */
    @NameInMap("id")
    public String id;

    public static SetRowsVisibilityResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SetRowsVisibilityResponseBody self = new SetRowsVisibilityResponseBody();
        return TeaModel.build(map, self);
    }

    public SetRowsVisibilityResponseBody setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

}
