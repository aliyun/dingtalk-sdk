// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class GetVersionInfoRequest extends TeaModel {
    @NameInMap("unifiedAppId")
    public String unifiedAppId;

    @NameInMap("versionId")
    public String versionId;

    public static GetVersionInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        GetVersionInfoRequest self = new GetVersionInfoRequest();
        return TeaModel.build(map, self);
    }

    public GetVersionInfoRequest setUnifiedAppId(String unifiedAppId) {
        this.unifiedAppId = unifiedAppId;
        return this;
    }
    public String getUnifiedAppId() {
        return this.unifiedAppId;
    }

    public GetVersionInfoRequest setVersionId(String versionId) {
        this.versionId = versionId;
        return this;
    }
    public String getVersionId() {
        return this.versionId;
    }

}
