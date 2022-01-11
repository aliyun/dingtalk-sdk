// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class CreateSheetResponseBody extends TeaModel {
    // 创建的工作表的名称。当输入参数中的工作表名称在表格中已存在时，可能与输入参数指定的工作表名称不同。
    @NameInMap("name")
    public String name;

    // 工作表可见性
    @NameInMap("visibility")
    public String visibility;

    public static CreateSheetResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateSheetResponseBody self = new CreateSheetResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateSheetResponseBody setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public CreateSheetResponseBody setVisibility(String visibility) {
        this.visibility = visibility;
        return this;
    }
    public String getVisibility() {
        return this.visibility;
    }

}
