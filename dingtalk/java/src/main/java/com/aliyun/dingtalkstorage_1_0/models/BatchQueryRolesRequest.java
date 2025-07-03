// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class BatchQueryRolesRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("dentryIdList")
    public java.util.List<String> dentryIdList;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>union_id</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static BatchQueryRolesRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchQueryRolesRequest self = new BatchQueryRolesRequest();
        return TeaModel.build(map, self);
    }

    public BatchQueryRolesRequest setDentryIdList(java.util.List<String> dentryIdList) {
        this.dentryIdList = dentryIdList;
        return this;
    }
    public java.util.List<String> getDentryIdList() {
        return this.dentryIdList;
    }

    public BatchQueryRolesRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
