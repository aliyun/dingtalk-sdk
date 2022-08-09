// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CustomizeContactDeptGroupCreateResponseBody extends TeaModel {
    // Id of the request
    @NameInMap("content")
    public String content;

    public static CustomizeContactDeptGroupCreateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CustomizeContactDeptGroupCreateResponseBody self = new CustomizeContactDeptGroupCreateResponseBody();
        return TeaModel.build(map, self);
    }

    public CustomizeContactDeptGroupCreateResponseBody setContent(String content) {
        this.content = content;
        return this;
    }
    public String getContent() {
        return this.content;
    }

}
