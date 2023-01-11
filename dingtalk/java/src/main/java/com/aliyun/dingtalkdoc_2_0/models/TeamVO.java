// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class TeamVO extends TeaModel {
    /**
     * <p>封面</p>
     */
    @NameInMap("cover")
    public String cover;

    /**
     * <p>创建时间</p>
     */
    @NameInMap("createdTime")
    public Long createdTime;

    /**
     * <p>创建人</p>
     */
    @NameInMap("creator")
    public TeamVOCreator creator;

    /**
     * <p>团队描述</p>
     */
    @NameInMap("description")
    public String description;

    /**
     * <p>图标</p>
     */
    @NameInMap("icon")
    public String icon;

    /**
     * <p>团队ID</p>
     */
    @NameInMap("id")
    public String id;

    /**
     * <p>团队名称</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>关联部门信息</p>
     */
    @NameInMap("relatedDeptInfo")
    public TeamVORelatedDeptInfo relatedDeptInfo;

    /**
     * <p>团队状态</p>
     */
    @NameInMap("status")
    public Integer status;

    /**
     * <p>团队类型</p>
     */
    @NameInMap("type")
    public Integer type;

    /**
     * <p>更新时间</p>
     */
    @NameInMap("updatedTime")
    public Long updatedTime;

    /**
     * <p>更新人</p>
     */
    @NameInMap("updater")
    public TeamVOUpdater updater;

    /**
     * <p>团队链接</p>
     */
    @NameInMap("url")
    public String url;

    /**
     * <p>用户对这个团队的访问情况</p>
     */
    @NameInMap("visitInfo")
    public TeamVOVisitInfo visitInfo;

    public static TeamVO build(java.util.Map<String, ?> map) throws Exception {
        TeamVO self = new TeamVO();
        return TeaModel.build(map, self);
    }

    public TeamVO setCover(String cover) {
        this.cover = cover;
        return this;
    }
    public String getCover() {
        return this.cover;
    }

    public TeamVO setCreatedTime(Long createdTime) {
        this.createdTime = createdTime;
        return this;
    }
    public Long getCreatedTime() {
        return this.createdTime;
    }

    public TeamVO setCreator(TeamVOCreator creator) {
        this.creator = creator;
        return this;
    }
    public TeamVOCreator getCreator() {
        return this.creator;
    }

    public TeamVO setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public TeamVO setIcon(String icon) {
        this.icon = icon;
        return this;
    }
    public String getIcon() {
        return this.icon;
    }

    public TeamVO setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

    public TeamVO setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public TeamVO setRelatedDeptInfo(TeamVORelatedDeptInfo relatedDeptInfo) {
        this.relatedDeptInfo = relatedDeptInfo;
        return this;
    }
    public TeamVORelatedDeptInfo getRelatedDeptInfo() {
        return this.relatedDeptInfo;
    }

    public TeamVO setStatus(Integer status) {
        this.status = status;
        return this;
    }
    public Integer getStatus() {
        return this.status;
    }

    public TeamVO setType(Integer type) {
        this.type = type;
        return this;
    }
    public Integer getType() {
        return this.type;
    }

    public TeamVO setUpdatedTime(Long updatedTime) {
        this.updatedTime = updatedTime;
        return this;
    }
    public Long getUpdatedTime() {
        return this.updatedTime;
    }

    public TeamVO setUpdater(TeamVOUpdater updater) {
        this.updater = updater;
        return this;
    }
    public TeamVOUpdater getUpdater() {
        return this.updater;
    }

    public TeamVO setUrl(String url) {
        this.url = url;
        return this;
    }
    public String getUrl() {
        return this.url;
    }

    public TeamVO setVisitInfo(TeamVOVisitInfo visitInfo) {
        this.visitInfo = visitInfo;
        return this;
    }
    public TeamVOVisitInfo getVisitInfo() {
        return this.visitInfo;
    }

    public static class TeamVOCreator extends TeaModel {
        /**
         * <p>名字</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>unionId</p>
         */
        @NameInMap("unionId")
        public String unionId;

        public static TeamVOCreator build(java.util.Map<String, ?> map) throws Exception {
            TeamVOCreator self = new TeamVOCreator();
            return TeaModel.build(map, self);
        }

        public TeamVOCreator setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public TeamVOCreator setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

    }

    public static class TeamVORelatedDeptInfo extends TeaModel {
        /**
         * <p>部门id</p>
         */
        @NameInMap("deptId")
        public String deptId;

        /**
         * <p>部门名称</p>
         */
        @NameInMap("deptName")
        public String deptName;

        public static TeamVORelatedDeptInfo build(java.util.Map<String, ?> map) throws Exception {
            TeamVORelatedDeptInfo self = new TeamVORelatedDeptInfo();
            return TeaModel.build(map, self);
        }

        public TeamVORelatedDeptInfo setDeptId(String deptId) {
            this.deptId = deptId;
            return this;
        }
        public String getDeptId() {
            return this.deptId;
        }

        public TeamVORelatedDeptInfo setDeptName(String deptName) {
            this.deptName = deptName;
            return this;
        }
        public String getDeptName() {
            return this.deptName;
        }

    }

    public static class TeamVOUpdater extends TeaModel {
        /**
         * <p>名字</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>unionId</p>
         */
        @NameInMap("unionId")
        public String unionId;

        public static TeamVOUpdater build(java.util.Map<String, ?> map) throws Exception {
            TeamVOUpdater self = new TeamVOUpdater();
            return TeaModel.build(map, self);
        }

        public TeamVOUpdater setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public TeamVOUpdater setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

    }

    public static class TeamVOVisitInfo extends TeaModel {
        /**
         * <p>用户对这个团队的访问情况</p>
         */
        @NameInMap("roleCode")
        public String roleCode;

        public static TeamVOVisitInfo build(java.util.Map<String, ?> map) throws Exception {
            TeamVOVisitInfo self = new TeamVOVisitInfo();
            return TeaModel.build(map, self);
        }

        public TeamVOVisitInfo setRoleCode(String roleCode) {
            this.roleCode = roleCode;
            return this;
        }
        public String getRoleCode() {
            return this.roleCode;
        }

    }

}
