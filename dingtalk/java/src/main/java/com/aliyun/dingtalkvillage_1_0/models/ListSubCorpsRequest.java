// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class ListSubCorpsRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("isOnlyDirect")
    public Boolean isOnlyDirect;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("subCorpId")
    public String subCorpId;

    /**
     * <strong>example:</strong>
     * <p>county|community</p>
     */
    @NameInMap("types")
    public String types;

    public static ListSubCorpsRequest build(java.util.Map<String, ?> map) throws Exception {
        ListSubCorpsRequest self = new ListSubCorpsRequest();
        return TeaModel.build(map, self);
    }

    public ListSubCorpsRequest setIsOnlyDirect(Boolean isOnlyDirect) {
        this.isOnlyDirect = isOnlyDirect;
        return this;
    }
    public Boolean getIsOnlyDirect() {
        return this.isOnlyDirect;
    }

    public ListSubCorpsRequest setSubCorpId(String subCorpId) {
        this.subCorpId = subCorpId;
        return this;
    }
    public String getSubCorpId() {
        return this.subCorpId;
    }

    public ListSubCorpsRequest setTypes(String types) {
        this.types = types;
        return this;
    }
    public String getTypes() {
        return this.types;
    }

}
