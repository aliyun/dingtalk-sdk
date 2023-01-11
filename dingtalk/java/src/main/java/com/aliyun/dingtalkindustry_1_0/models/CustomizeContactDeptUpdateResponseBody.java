// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CustomizeContactDeptUpdateResponseBody extends TeaModel {
    /**
     * <p>部门Id</p>
     */
    @NameInMap("content")
    public Long content;

    public static CustomizeContactDeptUpdateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CustomizeContactDeptUpdateResponseBody self = new CustomizeContactDeptUpdateResponseBody();
        return TeaModel.build(map, self);
    }

    public CustomizeContactDeptUpdateResponseBody setContent(Long content) {
        this.content = content;
        return this;
    }
    public Long getContent() {
        return this.content;
    }

}
