// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_2_0.models;

import com.aliyun.tea.*;

public class BatchAddOrUpdateRoleMembersRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>dingxxxx</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>[{&quot;memberId&quot;:&quot;5014533041684xx&quot;,&quot;manageScopes&quot;:&quot;8360866xx,430181xx,429821xx&quot;},{&quot;memberId&quot;:&quot;014329103xx&quot;,&quot;manageScopes&quot;:&quot;all&quot;}]</p>
     */
    @NameInMap("membersInfo")
    public String membersInfo;

    @NameInMap("pageNumber")
    public Integer pageNumber;

    @NameInMap("pageSize")
    public Integer pageSize;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>ROLE-71dc7859-17df-490d-a93d-eb5506e31f42</p>
     */
    @NameInMap("roleUuid")
    public String roleUuid;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("token")
    public String token;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>501453</p>
     */
    @NameInMap("userId")
    public String userId;

    public static BatchAddOrUpdateRoleMembersRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchAddOrUpdateRoleMembersRequest self = new BatchAddOrUpdateRoleMembersRequest();
        return TeaModel.build(map, self);
    }

    public BatchAddOrUpdateRoleMembersRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public BatchAddOrUpdateRoleMembersRequest setMembersInfo(String membersInfo) {
        this.membersInfo = membersInfo;
        return this;
    }
    public String getMembersInfo() {
        return this.membersInfo;
    }

    public BatchAddOrUpdateRoleMembersRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public BatchAddOrUpdateRoleMembersRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public BatchAddOrUpdateRoleMembersRequest setRoleUuid(String roleUuid) {
        this.roleUuid = roleUuid;
        return this;
    }
    public String getRoleUuid() {
        return this.roleUuid;
    }

    public BatchAddOrUpdateRoleMembersRequest setToken(String token) {
        this.token = token;
        return this;
    }
    public String getToken() {
        return this.token;
    }

    public BatchAddOrUpdateRoleMembersRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
