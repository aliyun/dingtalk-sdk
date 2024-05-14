// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CustomizeContactDeptDeleteResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("content")
    public Boolean content;

    public static CustomizeContactDeptDeleteResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CustomizeContactDeptDeleteResponseBody self = new CustomizeContactDeptDeleteResponseBody();
        return TeaModel.build(map, self);
    }

    public CustomizeContactDeptDeleteResponseBody setContent(Boolean content) {
        this.content = content;
        return this;
    }
    public Boolean getContent() {
        return this.content;
    }

}
