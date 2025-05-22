// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class Entity extends TeaModel {
    @NameInMap("children")
    public java.util.List<EntityChildren> children;

    /**
     * <strong>example:</strong>
     * <p>{&quot;title&quot;: &quot;123&quot;}</p>
     */
    @NameInMap("data")
    public java.util.Map<String, ?> data;

    /**
     * <strong>example:</strong>
     * <p>123</p>
     */
    @NameInMap("id")
    public String id;

    /**
     * <strong>example:</strong>
     * <p>y/n</p>
     */
    @NameInMap("isDeleted")
    public String isDeleted;

    /**
     * <strong>example:</strong>
     * <p>67dbb24f7aac3f62d8b98fb5</p>
     */
    @NameInMap("linkSourceId")
    public String linkSourceId;

    /**
     * <strong>example:</strong>
     * <p>EXTERNAL_PERF_TASK</p>
     */
    @NameInMap("linkSourceType")
    public String linkSourceType;

    @NameInMap("metas")
    public java.util.List<Meta> metas;

    /**
     * <strong>example:</strong>
     * <p>DIMENSION</p>
     */
    @NameInMap("type")
    public String type;

    public static Entity build(java.util.Map<String, ?> map) throws Exception {
        Entity self = new Entity();
        return TeaModel.build(map, self);
    }

    public Entity setChildren(java.util.List<EntityChildren> children) {
        this.children = children;
        return this;
    }
    public java.util.List<EntityChildren> getChildren() {
        return this.children;
    }

    public Entity setData(java.util.Map<String, ?> data) {
        this.data = data;
        return this;
    }
    public java.util.Map<String, ?> getData() {
        return this.data;
    }

    public Entity setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

    public Entity setIsDeleted(String isDeleted) {
        this.isDeleted = isDeleted;
        return this;
    }
    public String getIsDeleted() {
        return this.isDeleted;
    }

    public Entity setLinkSourceId(String linkSourceId) {
        this.linkSourceId = linkSourceId;
        return this;
    }
    public String getLinkSourceId() {
        return this.linkSourceId;
    }

    public Entity setLinkSourceType(String linkSourceType) {
        this.linkSourceType = linkSourceType;
        return this;
    }
    public String getLinkSourceType() {
        return this.linkSourceType;
    }

    public Entity setMetas(java.util.List<Meta> metas) {
        this.metas = metas;
        return this;
    }
    public java.util.List<Meta> getMetas() {
        return this.metas;
    }

    public Entity setType(String type) {
        this.type = type;
        return this;
    }
    public String getType() {
        return this.type;
    }

    public static class EntityChildren extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>{&quot;title&quot;: &quot;123&quot;}</p>
         */
        @NameInMap("data")
        public java.util.Map<String, ?> data;

        /**
         * <strong>example:</strong>
         * <p>123</p>
         */
        @NameInMap("id")
        public String id;

        /**
         * <strong>example:</strong>
         * <p>y/n</p>
         */
        @NameInMap("isDeleted")
        public String isDeleted;

        /**
         * <strong>example:</strong>
         * <p>67dbb24f7aac3f62d8b98fb5</p>
         */
        @NameInMap("linkSourceId")
        public String linkSourceId;

        /**
         * <strong>example:</strong>
         * <p>EXTERNAL_PERF_TASK</p>
         */
        @NameInMap("linkSourceType")
        public String linkSourceType;

        @NameInMap("metas")
        public java.util.List<Meta> metas;

        /**
         * <strong>example:</strong>
         * <p>DIMENSION</p>
         */
        @NameInMap("type")
        public String type;

        public static EntityChildren build(java.util.Map<String, ?> map) throws Exception {
            EntityChildren self = new EntityChildren();
            return TeaModel.build(map, self);
        }

        public EntityChildren setData(java.util.Map<String, ?> data) {
            this.data = data;
            return this;
        }
        public java.util.Map<String, ?> getData() {
            return this.data;
        }

        public EntityChildren setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public EntityChildren setIsDeleted(String isDeleted) {
            this.isDeleted = isDeleted;
            return this;
        }
        public String getIsDeleted() {
            return this.isDeleted;
        }

        public EntityChildren setLinkSourceId(String linkSourceId) {
            this.linkSourceId = linkSourceId;
            return this;
        }
        public String getLinkSourceId() {
            return this.linkSourceId;
        }

        public EntityChildren setLinkSourceType(String linkSourceType) {
            this.linkSourceType = linkSourceType;
            return this;
        }
        public String getLinkSourceType() {
            return this.linkSourceType;
        }

        public EntityChildren setMetas(java.util.List<Meta> metas) {
            this.metas = metas;
            return this;
        }
        public java.util.List<Meta> getMetas() {
            return this.metas;
        }

        public EntityChildren setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

}
