// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class DigitalStoreSubNodesResponseBody extends TeaModel {
    @NameInMap("content")
    public java.util.List<DigitalStoreSubNodesResponseBodyContent> content;

    public static DigitalStoreSubNodesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DigitalStoreSubNodesResponseBody self = new DigitalStoreSubNodesResponseBody();
        return TeaModel.build(map, self);
    }

    public DigitalStoreSubNodesResponseBody setContent(java.util.List<DigitalStoreSubNodesResponseBodyContent> content) {
        this.content = content;
        return this;
    }
    public java.util.List<DigitalStoreSubNodesResponseBodyContent> getContent() {
        return this.content;
    }

    public static class DigitalStoreSubNodesResponseBodyContent extends TeaModel {
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

        public static DigitalStoreSubNodesResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            DigitalStoreSubNodesResponseBodyContent self = new DigitalStoreSubNodesResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public DigitalStoreSubNodesResponseBodyContent setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public DigitalStoreSubNodesResponseBodyContent setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public DigitalStoreSubNodesResponseBodyContent setParentId(Long parentId) {
            this.parentId = parentId;
            return this;
        }
        public Long getParentId() {
            return this.parentId;
        }

        public DigitalStoreSubNodesResponseBodyContent setType(Long type) {
            this.type = type;
            return this;
        }
        public Long getType() {
            return this.type;
        }

    }

}
