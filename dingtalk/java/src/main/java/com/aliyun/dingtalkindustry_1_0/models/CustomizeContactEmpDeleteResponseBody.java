// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CustomizeContactEmpDeleteResponseBody extends TeaModel {
    @NameInMap("content")
    public Boolean content;

    public static CustomizeContactEmpDeleteResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CustomizeContactEmpDeleteResponseBody self = new CustomizeContactEmpDeleteResponseBody();
        return TeaModel.build(map, self);
    }

    public CustomizeContactEmpDeleteResponseBody setContent(Boolean content) {
        this.content = content;
        return this;
    }
    public Boolean getContent() {
        return this.content;
    }

}
