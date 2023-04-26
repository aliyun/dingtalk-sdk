// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class TeamModel extends TeaModel {
    @NameInMap("cover")
    public String cover;

    @NameInMap("createdTime")
    public Long createdTime;

    @NameInMap("creator")
    public TeamModelCreator creator;

    @NameInMap("description")
    public String description;

    @NameInMap("icon")
    public String icon;

    @NameInMap("id")
    public String id;

    @NameInMap("name")
    public String name;

    @NameInMap("relatedDeptInfo")
    public TeamModelRelatedDeptInfo relatedDeptInfo;

    @NameInMap("status")
    public Integer status;

    @NameInMap("type")
    public Integer type;

    @NameInMap("updatedTime")
    public Long updatedTime;

    @NameInMap("updater")
    public TeamModelUpdater updater;

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
        @NameInMap("name")
        public String name;

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
        @NameInMap("deptId")
        public String deptId;

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
        @NameInMap("name")
        public String name;

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
        @NameInMap("joinTime")
        public String joinTime;

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
