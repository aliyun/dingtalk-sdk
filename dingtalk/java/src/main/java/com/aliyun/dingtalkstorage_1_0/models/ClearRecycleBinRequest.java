// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class ClearRecycleBinRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>union_id</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static ClearRecycleBinRequest build(java.util.Map<String, ?> map) throws Exception {
        ClearRecycleBinRequest self = new ClearRecycleBinRequest();
        return TeaModel.build(map, self);
    }

    public ClearRecycleBinRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
