// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainLabelMetaStatusRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("codes")
    public java.util.List<String> codes;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("optType")
    public String optType;

    public static HrbrainLabelMetaStatusRequest build(java.util.Map<String, ?> map) throws Exception {
        HrbrainLabelMetaStatusRequest self = new HrbrainLabelMetaStatusRequest();
        return TeaModel.build(map, self);
    }

    public HrbrainLabelMetaStatusRequest setCodes(java.util.List<String> codes) {
        this.codes = codes;
        return this;
    }
    public java.util.List<String> getCodes() {
        return this.codes;
    }

    public HrbrainLabelMetaStatusRequest setOptType(String optType) {
        this.optType = optType;
        return this;
    }
    public String getOptType() {
        return this.optType;
    }

}
