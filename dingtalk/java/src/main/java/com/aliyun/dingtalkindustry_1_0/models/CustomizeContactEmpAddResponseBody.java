// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CustomizeContactEmpAddResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("content")
    public Boolean content;

    public static CustomizeContactEmpAddResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CustomizeContactEmpAddResponseBody self = new CustomizeContactEmpAddResponseBody();
        return TeaModel.build(map, self);
    }

    public CustomizeContactEmpAddResponseBody setContent(Boolean content) {
        this.content = content;
        return this;
    }
    public Boolean getContent() {
        return this.content;
    }

}
