// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainDeleteCustomRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("modelCode")
    public String modelCode;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("params")
    public java.util.List<java.util.Map<String, ?>> params;

    public static HrbrainDeleteCustomRequest build(java.util.Map<String, ?> map) throws Exception {
        HrbrainDeleteCustomRequest self = new HrbrainDeleteCustomRequest();
        return TeaModel.build(map, self);
    }

    public HrbrainDeleteCustomRequest setModelCode(String modelCode) {
        this.modelCode = modelCode;
        return this;
    }
    public String getModelCode() {
        return this.modelCode;
    }

    public HrbrainDeleteCustomRequest setParams(java.util.List<java.util.Map<String, ?>> params) {
        this.params = params;
        return this;
    }
    public java.util.List<java.util.Map<String, ?>> getParams() {
        return this.params;
    }

}
