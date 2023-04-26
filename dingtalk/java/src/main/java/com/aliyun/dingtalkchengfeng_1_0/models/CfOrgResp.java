// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class CfOrgResp extends TeaModel {
    @NameInMap("deptCode")
    public String deptCode;

    @NameInMap("deptName")
    public String deptName;

    @NameInMap("level")
    public Long level;

    @NameInMap("organizationCodePath")
    public String organizationCodePath;

    @NameInMap("organizationPath")
    public String organizationPath;

    @NameInMap("parentDeptCode")
    public String parentDeptCode;

    public static CfOrgResp build(java.util.Map<String, ?> map) throws Exception {
        CfOrgResp self = new CfOrgResp();
        return TeaModel.build(map, self);
    }

    public CfOrgResp setDeptCode(String deptCode) {
        this.deptCode = deptCode;
        return this;
    }
    public String getDeptCode() {
        return this.deptCode;
    }

    public CfOrgResp setDeptName(String deptName) {
        this.deptName = deptName;
        return this;
    }
    public String getDeptName() {
        return this.deptName;
    }

    public CfOrgResp setLevel(Long level) {
        this.level = level;
        return this;
    }
    public Long getLevel() {
        return this.level;
    }

    public CfOrgResp setOrganizationCodePath(String organizationCodePath) {
        this.organizationCodePath = organizationCodePath;
        return this;
    }
    public String getOrganizationCodePath() {
        return this.organizationCodePath;
    }

    public CfOrgResp setOrganizationPath(String organizationPath) {
        this.organizationPath = organizationPath;
        return this;
    }
    public String getOrganizationPath() {
        return this.organizationPath;
    }

    public CfOrgResp setParentDeptCode(String parentDeptCode) {
        this.parentDeptCode = parentDeptCode;
        return this;
    }
    public String getParentDeptCode() {
        return this.parentDeptCode;
    }

}
