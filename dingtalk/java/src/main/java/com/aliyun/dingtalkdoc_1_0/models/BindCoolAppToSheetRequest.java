// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class BindCoolAppToSheetRequest extends TeaModel {
    @NameInMap("coolAppCode")
    public String coolAppCode;

    @NameInMap("operatorId")
    public String operatorId;

    public static BindCoolAppToSheetRequest build(java.util.Map<String, ?> map) throws Exception {
        BindCoolAppToSheetRequest self = new BindCoolAppToSheetRequest();
        return TeaModel.build(map, self);
    }

    public BindCoolAppToSheetRequest setCoolAppCode(String coolAppCode) {
        this.coolAppCode = coolAppCode;
        return this;
    }
    public String getCoolAppCode() {
        return this.coolAppCode;
    }

    public BindCoolAppToSheetRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
