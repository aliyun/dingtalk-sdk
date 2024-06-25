// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class GetTotalNumberOfDentriesRequest extends TeaModel {
    @NameInMap("includeFolder")
    public Boolean includeFolder;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>abcd</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    @NameInMap("spaceTypes")
    public String spaceTypes;

    public static GetTotalNumberOfDentriesRequest build(java.util.Map<String, ?> map) throws Exception {
        GetTotalNumberOfDentriesRequest self = new GetTotalNumberOfDentriesRequest();
        return TeaModel.build(map, self);
    }

    public GetTotalNumberOfDentriesRequest setIncludeFolder(Boolean includeFolder) {
        this.includeFolder = includeFolder;
        return this;
    }
    public Boolean getIncludeFolder() {
        return this.includeFolder;
    }

    public GetTotalNumberOfDentriesRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public GetTotalNumberOfDentriesRequest setSpaceTypes(String spaceTypes) {
        this.spaceTypes = spaceTypes;
        return this;
    }
    public String getSpaceTypes() {
        return this.spaceTypes;
    }

}
