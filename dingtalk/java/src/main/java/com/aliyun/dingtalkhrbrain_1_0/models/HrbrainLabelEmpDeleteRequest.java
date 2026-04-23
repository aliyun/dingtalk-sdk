// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainLabelEmpDeleteRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("labelCode")
    public String labelCode;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("workNos")
    public java.util.List<String> workNos;

    public static HrbrainLabelEmpDeleteRequest build(java.util.Map<String, ?> map) throws Exception {
        HrbrainLabelEmpDeleteRequest self = new HrbrainLabelEmpDeleteRequest();
        return TeaModel.build(map, self);
    }

    public HrbrainLabelEmpDeleteRequest setLabelCode(String labelCode) {
        this.labelCode = labelCode;
        return this;
    }
    public String getLabelCode() {
        return this.labelCode;
    }

    public HrbrainLabelEmpDeleteRequest setWorkNos(java.util.List<String> workNos) {
        this.workNos = workNos;
        return this;
    }
    public java.util.List<String> getWorkNos() {
        return this.workNos;
    }

}
