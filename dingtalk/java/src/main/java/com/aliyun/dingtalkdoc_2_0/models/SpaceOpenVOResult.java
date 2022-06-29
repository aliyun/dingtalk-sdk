// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class SpaceOpenVOResult extends TeaModel {
    // 知识库id。
    @NameInMap("id")
    public String id;

    // 知识库名称。
    @NameInMap("name")
    public String name;

    // 知识库所有者。
    @NameInMap("owner")
    public SpaceOpenVOResultOwner owner;

    // 知识库访问url。
    @NameInMap("url")
    public String url;

    // 访问者对当前知识库的权限等信息。
    @NameInMap("visitorInfo")
    public SpaceOpenVOResultVisitorInfo visitorInfo;

    public static SpaceOpenVOResult build(java.util.Map<String, ?> map) throws Exception {
        SpaceOpenVOResult self = new SpaceOpenVOResult();
        return TeaModel.build(map, self);
    }

    public SpaceOpenVOResult setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

    public SpaceOpenVOResult setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public SpaceOpenVOResult setOwner(SpaceOpenVOResultOwner owner) {
        this.owner = owner;
        return this;
    }
    public SpaceOpenVOResultOwner getOwner() {
        return this.owner;
    }

    public SpaceOpenVOResult setUrl(String url) {
        this.url = url;
        return this;
    }
    public String getUrl() {
        return this.url;
    }

    public SpaceOpenVOResult setVisitorInfo(SpaceOpenVOResultVisitorInfo visitorInfo) {
        this.visitorInfo = visitorInfo;
        return this;
    }
    public SpaceOpenVOResultVisitorInfo getVisitorInfo() {
        return this.visitorInfo;
    }

    public static class SpaceOpenVOResultOwner extends TeaModel {
        // 用户名称。
        @NameInMap("name")
        public String name;

        // 用户unionId。
        @NameInMap("unionId")
        public String unionId;

        public static SpaceOpenVOResultOwner build(java.util.Map<String, ?> map) throws Exception {
            SpaceOpenVOResultOwner self = new SpaceOpenVOResultOwner();
            return TeaModel.build(map, self);
        }

        public SpaceOpenVOResultOwner setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public SpaceOpenVOResultOwner setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

    }

    public static class SpaceOpenVOResultVisitorInfo extends TeaModel {
        // 节点的操作列表。
        @NameInMap("dentryActions")
        public java.util.List<String> dentryActions;

        // 空间的操作列表。
        @NameInMap("spaceActions")
        public java.util.List<String> spaceActions;

        public static SpaceOpenVOResultVisitorInfo build(java.util.Map<String, ?> map) throws Exception {
            SpaceOpenVOResultVisitorInfo self = new SpaceOpenVOResultVisitorInfo();
            return TeaModel.build(map, self);
        }

        public SpaceOpenVOResultVisitorInfo setDentryActions(java.util.List<String> dentryActions) {
            this.dentryActions = dentryActions;
            return this;
        }
        public java.util.List<String> getDentryActions() {
            return this.dentryActions;
        }

        public SpaceOpenVOResultVisitorInfo setSpaceActions(java.util.List<String> spaceActions) {
            this.spaceActions = spaceActions;
            return this;
        }
        public java.util.List<String> getSpaceActions() {
            return this.spaceActions;
        }

    }

}
