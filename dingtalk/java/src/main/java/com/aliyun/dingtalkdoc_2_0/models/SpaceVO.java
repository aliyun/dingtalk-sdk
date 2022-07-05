// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class SpaceVO extends TeaModel {
    // 知识库id。
    @NameInMap("id")
    public String id;

    // 知识库名称。
    @NameInMap("name")
    public String name;

    // 知识库所有者。
    @NameInMap("owner")
    public SpaceVOOwner owner;

    // 知识库访问url。
    @NameInMap("url")
    public String url;

    // 访问者对当前知识库的权限等信息。
    @NameInMap("visitorInfo")
    public SpaceVOVisitorInfo visitorInfo;

    public static SpaceVO build(java.util.Map<String, ?> map) throws Exception {
        SpaceVO self = new SpaceVO();
        return TeaModel.build(map, self);
    }

    public SpaceVO setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

    public SpaceVO setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public SpaceVO setOwner(SpaceVOOwner owner) {
        this.owner = owner;
        return this;
    }
    public SpaceVOOwner getOwner() {
        return this.owner;
    }

    public SpaceVO setUrl(String url) {
        this.url = url;
        return this;
    }
    public String getUrl() {
        return this.url;
    }

    public SpaceVO setVisitorInfo(SpaceVOVisitorInfo visitorInfo) {
        this.visitorInfo = visitorInfo;
        return this;
    }
    public SpaceVOVisitorInfo getVisitorInfo() {
        return this.visitorInfo;
    }

    public static class SpaceVOOwner extends TeaModel {
        // 用户名称。
        @NameInMap("name")
        public String name;

        // 用户unionId。
        @NameInMap("unionId")
        public String unionId;

        public static SpaceVOOwner build(java.util.Map<String, ?> map) throws Exception {
            SpaceVOOwner self = new SpaceVOOwner();
            return TeaModel.build(map, self);
        }

        public SpaceVOOwner setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public SpaceVOOwner setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

    }

    public static class SpaceVOVisitorInfo extends TeaModel {
        // 节点的操作列表。
        @NameInMap("dentryActions")
        public java.util.List<String> dentryActions;

        // 空间的操作列表。
        @NameInMap("spaceActions")
        public java.util.List<String> spaceActions;

        public static SpaceVOVisitorInfo build(java.util.Map<String, ?> map) throws Exception {
            SpaceVOVisitorInfo self = new SpaceVOVisitorInfo();
            return TeaModel.build(map, self);
        }

        public SpaceVOVisitorInfo setDentryActions(java.util.List<String> dentryActions) {
            this.dentryActions = dentryActions;
            return this;
        }
        public java.util.List<String> getDentryActions() {
            return this.dentryActions;
        }

        public SpaceVOVisitorInfo setSpaceActions(java.util.List<String> spaceActions) {
            this.spaceActions = spaceActions;
            return this;
        }
        public java.util.List<String> getSpaceActions() {
            return this.spaceActions;
        }

    }

}
