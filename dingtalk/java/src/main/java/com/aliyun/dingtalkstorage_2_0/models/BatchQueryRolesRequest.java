// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_2_0.models;

import com.aliyun.tea.*;

public class BatchQueryRolesRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("dentryUuidList")
    public java.util.List<String> dentryUuidList;

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

    public BatchQueryRolesRequest setDentryUuidList(java.util.List<String> dentryUuidList) {
        this.dentryUuidList = dentryUuidList;
        return this;
    }
    public java.util.List<String> getDentryUuidList() {
        return this.dentryUuidList;
    }

    public BatchQueryRolesRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
