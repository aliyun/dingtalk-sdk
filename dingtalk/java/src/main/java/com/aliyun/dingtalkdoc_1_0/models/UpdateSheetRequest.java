// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class UpdateSheetRequest extends TeaModel {
    @NameInMap("name")
    public String name;

    @NameInMap("visibility")
    public String visibility;

    @NameInMap("operatorId")
    public String operatorId;

    public static UpdateSheetRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateSheetRequest self = new UpdateSheetRequest();
        return TeaModel.build(map, self);
    }

    public UpdateSheetRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public UpdateSheetRequest setVisibility(String visibility) {
        this.visibility = visibility;
        return this;
    }
    public String getVisibility() {
        return this.visibility;
    }

    public UpdateSheetRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
