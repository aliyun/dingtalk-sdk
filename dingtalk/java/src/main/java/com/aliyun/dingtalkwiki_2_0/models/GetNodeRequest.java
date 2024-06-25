// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkwiki_2_0.models;

import com.aliyun.tea.*;

public class GetNodeRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>union_id</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    /**
     * <strong>example:</strong>
     * <p>false</p>
     */
    @NameInMap("withPermissionRole")
    public Boolean withPermissionRole;

    /**
     * <strong>example:</strong>
     * <p>false</p>
     */
    @NameInMap("withStatisticalInfo")
    public Boolean withStatisticalInfo;

    public static GetNodeRequest build(java.util.Map<String, ?> map) throws Exception {
        GetNodeRequest self = new GetNodeRequest();
        return TeaModel.build(map, self);
    }

    public GetNodeRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public GetNodeRequest setWithPermissionRole(Boolean withPermissionRole) {
        this.withPermissionRole = withPermissionRole;
        return this;
    }
    public Boolean getWithPermissionRole() {
        return this.withPermissionRole;
    }

    public GetNodeRequest setWithStatisticalInfo(Boolean withStatisticalInfo) {
        this.withStatisticalInfo = withStatisticalInfo;
        return this;
    }
    public Boolean getWithStatisticalInfo() {
        return this.withStatisticalInfo;
    }

}
