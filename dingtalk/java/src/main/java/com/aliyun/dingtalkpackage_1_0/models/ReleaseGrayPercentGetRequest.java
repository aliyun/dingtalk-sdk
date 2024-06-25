// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpackage_1_0.models;

import com.aliyun.tea.*;

public class ReleaseGrayPercentGetRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>5000000000000000</p>
     */
    @NameInMap("miniAppId")
    public String miniAppId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>0.0.1</p>
     */
    @NameInMap("version")
    public String version;

    public static ReleaseGrayPercentGetRequest build(java.util.Map<String, ?> map) throws Exception {
        ReleaseGrayPercentGetRequest self = new ReleaseGrayPercentGetRequest();
        return TeaModel.build(map, self);
    }

    public ReleaseGrayPercentGetRequest setMiniAppId(String miniAppId) {
        this.miniAppId = miniAppId;
        return this;
    }
    public String getMiniAppId() {
        return this.miniAppId;
    }

    public ReleaseGrayPercentGetRequest setVersion(String version) {
        this.version = version;
        return this;
    }
    public String getVersion() {
        return this.version;
    }

}
