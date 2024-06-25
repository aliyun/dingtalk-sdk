// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class DeactivateDeviceRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>model1</p>
     */
    @NameInMap("model")
    public String model;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>fdafds-432432</p>
     */
    @NameInMap("sn")
    public String sn;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>VIDEO_CALL</p>
     */
    @NameInMap("type")
    public String type;

    public static DeactivateDeviceRequest build(java.util.Map<String, ?> map) throws Exception {
        DeactivateDeviceRequest self = new DeactivateDeviceRequest();
        return TeaModel.build(map, self);
    }

    public DeactivateDeviceRequest setModel(String model) {
        this.model = model;
        return this;
    }
    public String getModel() {
        return this.model;
    }

    public DeactivateDeviceRequest setSn(String sn) {
        this.sn = sn;
        return this;
    }
    public String getSn() {
        return this.sn;
    }

    public DeactivateDeviceRequest setType(String type) {
        this.type = type;
        return this;
    }
    public String getType() {
        return this.type;
    }

}
