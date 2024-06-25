// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpackage_1_0.models;

import com.aliyun.tea.*;

public class ReleaseGrayPercentSetRequest extends TeaModel {
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
     * <p>10</p>
     */
    @NameInMap("value")
    public Double value;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>0.0.1</p>
     */
    @NameInMap("version")
    public String version;

    public static ReleaseGrayPercentSetRequest build(java.util.Map<String, ?> map) throws Exception {
        ReleaseGrayPercentSetRequest self = new ReleaseGrayPercentSetRequest();
        return TeaModel.build(map, self);
    }

    public ReleaseGrayPercentSetRequest setMiniAppId(String miniAppId) {
        this.miniAppId = miniAppId;
        return this;
    }
    public String getMiniAppId() {
        return this.miniAppId;
    }

    public ReleaseGrayPercentSetRequest setValue(Double value) {
        this.value = value;
        return this;
    }
    public Double getValue() {
        return this.value;
    }

    public ReleaseGrayPercentSetRequest setVersion(String version) {
        this.version = version;
        return this;
    }
    public String getVersion() {
        return this.version;
    }

}
