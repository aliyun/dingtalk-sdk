// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class DeleteDentryRequest extends TeaModel {
    // 是否删除到回收站，默认不删除到回收站，直接删除
    // 默认值:
    // 	false
    @NameInMap("toRecycleBin")
    public Boolean toRecycleBin;

    // 用户id
    @NameInMap("unionId")
    public String unionId;

    public static DeleteDentryRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteDentryRequest self = new DeleteDentryRequest();
        return TeaModel.build(map, self);
    }

    public DeleteDentryRequest setToRecycleBin(Boolean toRecycleBin) {
        this.toRecycleBin = toRecycleBin;
        return this;
    }
    public Boolean getToRecycleBin() {
        return this.toRecycleBin;
    }

    public DeleteDentryRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
