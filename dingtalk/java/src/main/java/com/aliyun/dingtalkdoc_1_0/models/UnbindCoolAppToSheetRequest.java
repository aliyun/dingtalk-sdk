// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class UnbindCoolAppToSheetRequest extends TeaModel {
    @NameInMap("coolAppCode")
    public String coolAppCode;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static UnbindCoolAppToSheetRequest build(java.util.Map<String, ?> map) throws Exception {
        UnbindCoolAppToSheetRequest self = new UnbindCoolAppToSheetRequest();
        return TeaModel.build(map, self);
    }

    public UnbindCoolAppToSheetRequest setCoolAppCode(String coolAppCode) {
        this.coolAppCode = coolAppCode;
        return this;
    }
    public String getCoolAppCode() {
        return this.coolAppCode;
    }

    public UnbindCoolAppToSheetRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
