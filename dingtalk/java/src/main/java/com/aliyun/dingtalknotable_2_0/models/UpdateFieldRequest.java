// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_2_0.models;

import com.aliyun.tea.*;

public class UpdateFieldRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("name")
    public String name;

    @NameInMap("property")
    public java.util.Map<String, ?> property;

    public static UpdateFieldRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateFieldRequest self = new UpdateFieldRequest();
        return TeaModel.build(map, self);
    }

    public UpdateFieldRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public UpdateFieldRequest setProperty(java.util.Map<String, ?> property) {
        this.property = property;
        return this;
    }
    public java.util.Map<String, ?> getProperty() {
        return this.property;
    }

}
