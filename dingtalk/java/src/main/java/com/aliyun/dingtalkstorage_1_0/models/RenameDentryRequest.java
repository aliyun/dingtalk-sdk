// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class RenameDentryRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("newName")
    public String newName;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static RenameDentryRequest build(java.util.Map<String, ?> map) throws Exception {
        RenameDentryRequest self = new RenameDentryRequest();
        return TeaModel.build(map, self);
    }

    public RenameDentryRequest setNewName(String newName) {
        this.newName = newName;
        return this;
    }
    public String getNewName() {
        return this.newName;
    }

    public RenameDentryRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
