// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class DigitalStoreNodeInfoResponseBody extends TeaModel {
    @NameInMap("dingDeptId")
    public Long dingDeptId;

    @NameInMap("id")
    public Long id;

    @NameInMap("name")
    public String name;

    @NameInMap("parentId")
    public Long parentId;

    @NameInMap("type")
    public Long type;

    public static DigitalStoreNodeInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DigitalStoreNodeInfoResponseBody self = new DigitalStoreNodeInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public DigitalStoreNodeInfoResponseBody setDingDeptId(Long dingDeptId) {
        this.dingDeptId = dingDeptId;
        return this;
    }
    public Long getDingDeptId() {
        return this.dingDeptId;
    }

    public DigitalStoreNodeInfoResponseBody setId(Long id) {
        this.id = id;
        return this;
    }
    public Long getId() {
        return this.id;
    }

    public DigitalStoreNodeInfoResponseBody setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public DigitalStoreNodeInfoResponseBody setParentId(Long parentId) {
        this.parentId = parentId;
        return this;
    }
    public Long getParentId() {
        return this.parentId;
    }

    public DigitalStoreNodeInfoResponseBody setType(Long type) {
        this.type = type;
        return this;
    }
    public Long getType() {
        return this.type;
    }

}
