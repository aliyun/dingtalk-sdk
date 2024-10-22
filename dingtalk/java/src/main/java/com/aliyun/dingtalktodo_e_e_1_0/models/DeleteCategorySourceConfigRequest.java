// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_e_e_1_0.models;

import com.aliyun.tea.*;

public class DeleteCategorySourceConfigRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1001</p>
     */
    @NameInMap("bizCategoryId")
    public String bizCategoryId;

    public static DeleteCategorySourceConfigRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteCategorySourceConfigRequest self = new DeleteCategorySourceConfigRequest();
        return TeaModel.build(map, self);
    }

    public DeleteCategorySourceConfigRequest setBizCategoryId(String bizCategoryId) {
        this.bizCategoryId = bizCategoryId;
        return this;
    }
    public String getBizCategoryId() {
        return this.bizCategoryId;
    }

}
