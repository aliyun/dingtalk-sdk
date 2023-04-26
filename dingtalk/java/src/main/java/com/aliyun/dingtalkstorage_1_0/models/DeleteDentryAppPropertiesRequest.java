// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class DeleteDentryAppPropertiesRequest extends TeaModel {
    @NameInMap("propertyNames")
    public java.util.List<String> propertyNames;

    @NameInMap("unionId")
    public String unionId;

    public static DeleteDentryAppPropertiesRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteDentryAppPropertiesRequest self = new DeleteDentryAppPropertiesRequest();
        return TeaModel.build(map, self);
    }

    public DeleteDentryAppPropertiesRequest setPropertyNames(java.util.List<String> propertyNames) {
        this.propertyNames = propertyNames;
        return this;
    }
    public java.util.List<String> getPropertyNames() {
        return this.propertyNames;
    }

    public DeleteDentryAppPropertiesRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
