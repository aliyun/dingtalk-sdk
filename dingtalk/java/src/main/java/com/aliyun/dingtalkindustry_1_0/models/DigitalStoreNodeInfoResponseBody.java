// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class DigitalStoreNodeInfoResponseBody extends TeaModel {
    // 节点Id
    @NameInMap("id")
    public Long id;

    // 门店名称
    @NameInMap("name")
    public String name;

    // 上级节点id
    @NameInMap("parentId")
    public Long parentId;

    // 节点类型
    @NameInMap("type")
    public Long type;

    public static DigitalStoreNodeInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DigitalStoreNodeInfoResponseBody self = new DigitalStoreNodeInfoResponseBody();
        return TeaModel.build(map, self);
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
