// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class SpaceOpenVO extends TeaModel {
    // 知识库id。
    @NameInMap("id")
    public String id;

    // 知识库名称。
    @NameInMap("name")
    public String name;

    // 知识库所有者。
    @NameInMap("owner")
    public SpaceOpenVOOwner owner;

    // 访问者对当前知识库的权限等信息。
    @NameInMap("visitorInfo")
    public SpaceOpenVOVisitorInfo visitorInfo;

    public static SpaceOpenVO build(java.util.Map<String, ?> map) throws Exception {
        SpaceOpenVO self = new SpaceOpenVO();
        return TeaModel.build(map, self);
    }

    public SpaceOpenVO setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

    public SpaceOpenVO setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public SpaceOpenVO setOwner(SpaceOpenVOOwner owner) {
        this.owner = owner;
        return this;
    }
    public SpaceOpenVOOwner getOwner() {
        return this.owner;
    }

    public SpaceOpenVO setVisitorInfo(SpaceOpenVOVisitorInfo visitorInfo) {
        this.visitorInfo = visitorInfo;
        return this;
    }
    public SpaceOpenVOVisitorInfo getVisitorInfo() {
        return this.visitorInfo;
    }

    public static class SpaceOpenVOOwner extends TeaModel {
        // 用户名称。
        @NameInMap("name")
        public String name;

        // 用户unionId。
        @NameInMap("unionId")
        public String unionId;

        public static SpaceOpenVOOwner build(java.util.Map<String, ?> map) throws Exception {
            SpaceOpenVOOwner self = new SpaceOpenVOOwner();
            return TeaModel.build(map, self);
        }

        public SpaceOpenVOOwner setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public SpaceOpenVOOwner setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

    }

    public static class SpaceOpenVOVisitorInfo extends TeaModel {
        // 节点的操作列表。
        @NameInMap("dentryActions")
        public java.util.List<String> dentryActions;

        // 空间的操作列表。
        @NameInMap("spaceActions")
        public java.util.List<String> spaceActions;

        public static SpaceOpenVOVisitorInfo build(java.util.Map<String, ?> map) throws Exception {
            SpaceOpenVOVisitorInfo self = new SpaceOpenVOVisitorInfo();
            return TeaModel.build(map, self);
        }

        public SpaceOpenVOVisitorInfo setDentryActions(java.util.List<String> dentryActions) {
            this.dentryActions = dentryActions;
            return this;
        }
        public java.util.List<String> getDentryActions() {
            return this.dentryActions;
        }

        public SpaceOpenVOVisitorInfo setSpaceActions(java.util.List<String> spaceActions) {
            this.spaceActions = spaceActions;
            return this;
        }
        public java.util.List<String> getSpaceActions() {
            return this.spaceActions;
        }

    }

}
