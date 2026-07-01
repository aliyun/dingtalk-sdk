// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class CreateTeamRequest extends TeaModel {
    @NameInMap("adminUserIds")
    public java.util.List<String> adminUserIds;

    @NameInMap("deptIds")
    public java.util.List<Long> deptIds;

    @NameInMap("dialectCode")
    public String dialectCode;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("sceneCodes")
    public java.util.List<String> sceneCodes;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("solutionCode")
    public String solutionCode;

    @NameInMap("userIds")
    public java.util.List<String> userIds;

    public static CreateTeamRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateTeamRequest self = new CreateTeamRequest();
        return TeaModel.build(map, self);
    }

    public CreateTeamRequest setAdminUserIds(java.util.List<String> adminUserIds) {
        this.adminUserIds = adminUserIds;
        return this;
    }
    public java.util.List<String> getAdminUserIds() {
        return this.adminUserIds;
    }

    public CreateTeamRequest setDeptIds(java.util.List<Long> deptIds) {
        this.deptIds = deptIds;
        return this;
    }
    public java.util.List<Long> getDeptIds() {
        return this.deptIds;
    }

    public CreateTeamRequest setDialectCode(String dialectCode) {
        this.dialectCode = dialectCode;
        return this;
    }
    public String getDialectCode() {
        return this.dialectCode;
    }

    public CreateTeamRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public CreateTeamRequest setSceneCodes(java.util.List<String> sceneCodes) {
        this.sceneCodes = sceneCodes;
        return this;
    }
    public java.util.List<String> getSceneCodes() {
        return this.sceneCodes;
    }

    public CreateTeamRequest setSolutionCode(String solutionCode) {
        this.solutionCode = solutionCode;
        return this;
    }
    public String getSolutionCode() {
        return this.solutionCode;
    }

    public CreateTeamRequest setUserIds(java.util.List<String> userIds) {
        this.userIds = userIds;
        return this;
    }
    public java.util.List<String> getUserIds() {
        return this.userIds;
    }

}
