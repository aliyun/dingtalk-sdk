// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QuerySelfBuildGroupUserInfoRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("classId")
    public Long classId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("roles")
    public java.util.List<String> roles;

    public static QuerySelfBuildGroupUserInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        QuerySelfBuildGroupUserInfoRequest self = new QuerySelfBuildGroupUserInfoRequest();
        return TeaModel.build(map, self);
    }

    public QuerySelfBuildGroupUserInfoRequest setClassId(Long classId) {
        this.classId = classId;
        return this;
    }
    public Long getClassId() {
        return this.classId;
    }

    public QuerySelfBuildGroupUserInfoRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public QuerySelfBuildGroupUserInfoRequest setRoles(java.util.List<String> roles) {
        this.roles = roles;
        return this;
    }
    public java.util.List<String> getRoles() {
        return this.roles;
    }

}
