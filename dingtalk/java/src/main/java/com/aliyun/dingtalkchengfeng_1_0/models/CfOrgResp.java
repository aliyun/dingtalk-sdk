// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class CfOrgResp extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>01</p>
     */
    @NameInMap("deptCode")
    public String deptCode;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>一级部门</p>
     */
    @NameInMap("deptName")
    public String deptName;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("level")
    public Long level;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1/01</p>
     */
    @NameInMap("organizationCodePath")
    public String organizationCodePath;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>公司/一级部门</p>
     */
    @NameInMap("organizationPath")
    public String organizationPath;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1</p>
     */
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
