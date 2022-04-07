// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CustomizeContactDeleteResponseBody extends TeaModel {
    // 是否操作成功
    @NameInMap("content")
    public Boolean content;

    public static CustomizeContactDeleteResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CustomizeContactDeleteResponseBody self = new CustomizeContactDeleteResponseBody();
        return TeaModel.build(map, self);
    }

    public CustomizeContactDeleteResponseBody setContent(Boolean content) {
        this.content = content;
        return this;
    }
    public Boolean getContent() {
        return this.content;
    }

}
