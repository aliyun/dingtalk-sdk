// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class BatchQueryRolesShrinkRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("dentryIdList")
    public String dentryIdListShrink;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>union_id</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static BatchQueryRolesShrinkRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchQueryRolesShrinkRequest self = new BatchQueryRolesShrinkRequest();
        return TeaModel.build(map, self);
    }

    public BatchQueryRolesShrinkRequest setDentryIdListShrink(String dentryIdListShrink) {
        this.dentryIdListShrink = dentryIdListShrink;
        return this;
    }
    public String getDentryIdListShrink() {
        return this.dentryIdListShrink;
    }

    public BatchQueryRolesShrinkRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
