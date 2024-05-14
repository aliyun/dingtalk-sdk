// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CustomizeContactDeptCreateResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("content")
    public Long content;

    public static CustomizeContactDeptCreateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CustomizeContactDeptCreateResponseBody self = new CustomizeContactDeptCreateResponseBody();
        return TeaModel.build(map, self);
    }

    public CustomizeContactDeptCreateResponseBody setContent(Long content) {
        this.content = content;
        return this;
    }
    public Long getContent() {
        return this.content;
    }

}
