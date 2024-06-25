// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class TeamModel extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p><a href="https://abc.com">https://abc.com</a></p>
     */
    @NameInMap("cover")
    public String cover;

    /**
     * <strong>example:</strong>
     * <p>12340000</p>
     */
    @NameInMap("createdTime")
    public Long createdTime;

    @NameInMap("creator")
    public TeamModelCreator creator;

    /**
     * <strong>example:</strong>
     * <p>这里是团队描述</p>
     */
    @NameInMap("description")
    public String description;

    /**
     * <strong>example:</strong>
     * <p><a href="https://def.com">https://def.com</a></p>
     */
    @NameInMap("icon")
    public String icon;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>AbcDef</p>
     */
    @NameInMap("id")
    public String id;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>测试团队名称</p>
     */
    @NameInMap("name")
    public String name;

    @NameInMap("relatedDeptInfo")
    public TeamModelRelatedDeptInfo relatedDeptInfo;

    /**
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("status")
    public Integer status;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("type")
    public Integer type;

    /**
     * <strong>example:</strong>
     * <p>34560000</p>
     */
    @NameInMap("updatedTime")
    public Long updatedTime;

    @NameInMap("updater")
    public TeamModelUpdater updater;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p><a href="https://abc.com">https://abc.com</a></p>
     */
    @NameInMap("url")
    public String url;

    @NameInMap("visitInfo")
    public TeamModelVisitInfo visitInfo;

    public static TeamModel build(java.util.Map<String, ?> map) throws Exception {
        TeamModel self = new TeamModel();
        return TeaModel.build(map, self);
    }

    public TeamModel setCover(String cover) {
        this.cover = cover;
        return this;
    }
    public String getCover() {
        return this.cover;
    }

    public TeamModel setCreatedTime(Long createdTime) {
        this.createdTime = createdTime;
        return this;
    }
    public Long getCreatedTime() {
        return this.createdTime;
    }

    public TeamModel setCreator(TeamModelCreator creator) {
        this.creator = creator;
        return this;
    }
    public TeamModelCreator getCreator() {
        return this.creator;
    }

    public TeamModel setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public TeamModel setIcon(String icon) {
        this.icon = icon;
        return this;
    }
    public String getIcon() {
        return this.icon;
    }

    public TeamModel setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

    public TeamModel setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public TeamModel setRelatedDeptInfo(TeamModelRelatedDeptInfo relatedDeptInfo) {
        this.relatedDeptInfo = relatedDeptInfo;
        return this;
    }
    public TeamModelRelatedDeptInfo getRelatedDeptInfo() {
        return this.relatedDeptInfo;
    }

    public TeamModel setStatus(Integer status) {
        this.status = status;
        return this;
    }
    public Integer getStatus() {
        return this.status;
    }

    public TeamModel setType(Integer type) {
        this.type = type;
        return this;
    }
    public Integer getType() {
        return this.type;
    }

    public TeamModel setUpdatedTime(Long updatedTime) {
        this.updatedTime = updatedTime;
        return this;
    }
    public Long getUpdatedTime() {
        return this.updatedTime;
    }

    public TeamModel setUpdater(TeamModelUpdater updater) {
        this.updater = updater;
        return this;
    }
    public TeamModelUpdater getUpdater() {
        return this.updater;
    }

    public TeamModel setUrl(String url) {
        this.url = url;
        return this;
    }
    public String getUrl() {
        return this.url;
    }

    public TeamModel setVisitInfo(TeamModelVisitInfo visitInfo) {
        this.visitInfo = visitInfo;
        return this;
    }
    public TeamModelVisitInfo getVisitInfo() {
        return this.visitInfo;
    }

    public static class TeamModelCreator extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>测试</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>abcd</p>
         */
        @NameInMap("unionId")
        public String unionId;

        public static TeamModelCreator build(java.util.Map<String, ?> map) throws Exception {
            TeamModelCreator self = new TeamModelCreator();
            return TeaModel.build(map, self);
        }

        public TeamModelCreator setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public TeamModelCreator setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

    }

    public static class TeamModelRelatedDeptInfo extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>abc</p>
         */
        @NameInMap("deptId")
        public String deptId;

        /**
         * <strong>example:</strong>
         * <p>测试部门</p>
         */
        @NameInMap("deptName")
        public String deptName;

        public static TeamModelRelatedDeptInfo build(java.util.Map<String, ?> map) throws Exception {
            TeamModelRelatedDeptInfo self = new TeamModelRelatedDeptInfo();
            return TeaModel.build(map, self);
        }

        public TeamModelRelatedDeptInfo setDeptId(String deptId) {
            this.deptId = deptId;
            return this;
        }
        public String getDeptId() {
            return this.deptId;
        }

        public TeamModelRelatedDeptInfo setDeptName(String deptName) {
            this.deptName = deptName;
            return this;
        }
        public String getDeptName() {
            return this.deptName;
        }

    }

    public static class TeamModelUpdater extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>测试</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>abcd</p>
         */
        @NameInMap("unionId")
        public String unionId;

        public static TeamModelUpdater build(java.util.Map<String, ?> map) throws Exception {
            TeamModelUpdater self = new TeamModelUpdater();
            return TeaModel.build(map, self);
        }

        public TeamModelUpdater setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public TeamModelUpdater setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

    }

    public static class TeamModelVisitInfo extends TeaModel {
        /**
         * <p>Use the UTC time format: yyyy-MM-ddTHH:mmZ</p>
         */
        @NameInMap("joinTime")
        public String joinTime;

        /**
         * <strong>example:</strong>
         * <p>5</p>
         */
        @NameInMap("roleCode")
        public String roleCode;

        public static TeamModelVisitInfo build(java.util.Map<String, ?> map) throws Exception {
            TeamModelVisitInfo self = new TeamModelVisitInfo();
            return TeaModel.build(map, self);
        }

        public TeamModelVisitInfo setJoinTime(String joinTime) {
            this.joinTime = joinTime;
            return this;
        }
        public String getJoinTime() {
            return this.joinTime;
        }

        public TeamModelVisitInfo setRoleCode(String roleCode) {
            this.roleCode = roleCode;
            return this;
        }
        public String getRoleCode() {
            return this.roleCode;
        }

    }

}
