// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_2_0.models;

import com.aliyun.tea.*;

public class GetRelationUkSettingRequest extends TeaModel {
    @NameInMap("relationType")
    public String relationType;

    public static GetRelationUkSettingRequest build(java.util.Map<String, ?> map) throws Exception {
        GetRelationUkSettingRequest self = new GetRelationUkSettingRequest();
        return TeaModel.build(map, self);
    }

    public GetRelationUkSettingRequest setRelationType(String relationType) {
        this.relationType = relationType;
        return this;
    }
    public String getRelationType() {
        return this.relationType;
    }

}
