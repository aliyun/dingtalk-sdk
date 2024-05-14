// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class DigitalStoreSubNodesResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
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
        @NameInMap("dingDeptId")
        public Long dingDeptId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("id")
        public Long id;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("parentId")
        public Long parentId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("type")
        public Long type;

        public static DigitalStoreSubNodesResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            DigitalStoreSubNodesResponseBodyContent self = new DigitalStoreSubNodesResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public DigitalStoreSubNodesResponseBodyContent setDingDeptId(Long dingDeptId) {
            this.dingDeptId = dingDeptId;
            return this;
        }
        public Long getDingDeptId() {
            return this.dingDeptId;
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
