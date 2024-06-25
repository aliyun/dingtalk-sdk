// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class SpaceVO extends TeaModel {
    @NameInMap("cover")
    public String cover;

    @NameInMap("description")
    public String description;

    @NameInMap("iconVO")
    public SpaceVOIconVO iconVO;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>abc</p>
     */
    @NameInMap("id")
    public String id;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>hello</p>
     */
    @NameInMap("name")
    public String name;

    @NameInMap("owner")
    public SpaceVOOwner owner;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("type")
    public Integer type;

    /**
     * <strong>example:</strong>
     * <p><a href="https://xx.yy">https://xx.yy</a></p>
     */
    @NameInMap("url")
    public String url;

    @NameInMap("visitorInfo")
    public SpaceVOVisitorInfo visitorInfo;

    public static SpaceVO build(java.util.Map<String, ?> map) throws Exception {
        SpaceVO self = new SpaceVO();
        return TeaModel.build(map, self);
    }

    public SpaceVO setCover(String cover) {
        this.cover = cover;
        return this;
    }
    public String getCover() {
        return this.cover;
    }

    public SpaceVO setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public SpaceVO setIconVO(SpaceVOIconVO iconVO) {
        this.iconVO = iconVO;
        return this;
    }
    public SpaceVOIconVO getIconVO() {
        return this.iconVO;
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

    public SpaceVO setType(Integer type) {
        this.type = type;
        return this;
    }
    public Integer getType() {
        return this.type;
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

    public static class SpaceVOIconVO extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("icon")
        public String icon;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("type")
        public String type;

        public static SpaceVOIconVO build(java.util.Map<String, ?> map) throws Exception {
            SpaceVOIconVO self = new SpaceVOIconVO();
            return TeaModel.build(map, self);
        }

        public SpaceVOIconVO setIcon(String icon) {
            this.icon = icon;
            return this;
        }
        public String getIcon() {
            return this.icon;
        }

        public SpaceVOIconVO setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class SpaceVOOwner extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>dingtalk</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>abcd</p>
         */
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
        @NameInMap("dentryActions")
        public java.util.List<String> dentryActions;

        @NameInMap("roleCode")
        public String roleCode;

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

        public SpaceVOVisitorInfo setRoleCode(String roleCode) {
            this.roleCode = roleCode;
            return this;
        }
        public String getRoleCode() {
            return this.roleCode;
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
