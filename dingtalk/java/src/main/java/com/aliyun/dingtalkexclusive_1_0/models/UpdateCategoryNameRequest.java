// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class UpdateCategoryNameRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>demo</p>
     */
    @NameInMap("currentCategoryName")
    public String currentCategoryName;

    /**
     * <strong>example:</strong>
     * <p>demo01</p>
     */
    @NameInMap("targetCategoryName")
    public String targetCategoryName;

    public static UpdateCategoryNameRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateCategoryNameRequest self = new UpdateCategoryNameRequest();
        return TeaModel.build(map, self);
    }

    public UpdateCategoryNameRequest setCurrentCategoryName(String currentCategoryName) {
        this.currentCategoryName = currentCategoryName;
        return this;
    }
    public String getCurrentCategoryName() {
        return this.currentCategoryName;
    }

    public UpdateCategoryNameRequest setTargetCategoryName(String targetCategoryName) {
        this.targetCategoryName = targetCategoryName;
        return this;
    }
    public String getTargetCategoryName() {
        return this.targetCategoryName;
    }

}
