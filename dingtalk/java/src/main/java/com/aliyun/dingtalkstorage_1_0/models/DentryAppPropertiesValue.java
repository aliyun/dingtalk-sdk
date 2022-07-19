// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class DentryAppPropertiesValue extends TeaModel {
    // 属性名称 该属性名称在当前app下需要保证唯一，不同app间同名属性互不影响
    @NameInMap("name")
    public String name;

    // 属性值
    @NameInMap("value")
    public String value;

    // 属性可见范围
    // 枚举值:
    // 	PUBLIC: 该属性所有App可见
    // 	PRIVATE: 该属性仅其归属App可见
    // 默认值:
    // 	PRIVATE
    @NameInMap("visibility")
    public String visibility;

    public static DentryAppPropertiesValue build(java.util.Map<String, ?> map) throws Exception {
        DentryAppPropertiesValue self = new DentryAppPropertiesValue();
        return TeaModel.build(map, self);
    }

    public DentryAppPropertiesValue setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public DentryAppPropertiesValue setValue(String value) {
        this.value = value;
        return this;
    }
    public String getValue() {
        return this.value;
    }

    public DentryAppPropertiesValue setVisibility(String visibility) {
        this.visibility = visibility;
        return this;
    }
    public String getVisibility() {
        return this.visibility;
    }

}
