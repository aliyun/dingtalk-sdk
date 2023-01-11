// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class DeleteDentryAppPropertiesRequest extends TeaModel {
    /**
     * <p>文件上App属性名称</p>
     * <p>最大size:</p>
     * <p>	3</p>
     */
    @NameInMap("propertyNames")
    public java.util.List<String> propertyNames;

    /**
     * <p>用户id</p>
     */
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
