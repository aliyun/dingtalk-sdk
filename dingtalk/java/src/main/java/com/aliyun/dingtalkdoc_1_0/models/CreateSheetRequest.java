// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class CreateSheetRequest extends TeaModel {
    // 操作人unionId
    @NameInMap("operatorId")
    public String operatorId;

    // 工作表名称
    @NameInMap("name")
    public String name;

    public static CreateSheetRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateSheetRequest self = new CreateSheetRequest();
        return TeaModel.build(map, self);
    }

    public CreateSheetRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public CreateSheetRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

}
