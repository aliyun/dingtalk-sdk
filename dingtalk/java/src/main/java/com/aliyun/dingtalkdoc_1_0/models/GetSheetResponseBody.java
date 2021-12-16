// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class GetSheetResponseBody extends TeaModel {
    // 工作表名称
    @NameInMap("name")
    public java.util.List<String> name;

    // 工作表可见性
    @NameInMap("visibility")
    public java.util.List<String> visibility;

    public static GetSheetResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetSheetResponseBody self = new GetSheetResponseBody();
        return TeaModel.build(map, self);
    }

    public GetSheetResponseBody setName(java.util.List<String> name) {
        this.name = name;
        return this;
    }
    public java.util.List<String> getName() {
        return this.name;
    }

    public GetSheetResponseBody setVisibility(java.util.List<String> visibility) {
        this.visibility = visibility;
        return this;
    }
    public java.util.List<String> getVisibility() {
        return this.visibility;
    }

}
