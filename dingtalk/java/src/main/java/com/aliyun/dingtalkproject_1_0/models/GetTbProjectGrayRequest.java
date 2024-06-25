// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class GetTbProjectGrayRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>project_teambition</p>
     */
    @NameInMap("label")
    public String label;

    public static GetTbProjectGrayRequest build(java.util.Map<String, ?> map) throws Exception {
        GetTbProjectGrayRequest self = new GetTbProjectGrayRequest();
        return TeaModel.build(map, self);
    }

    public GetTbProjectGrayRequest setLabel(String label) {
        this.label = label;
        return this;
    }
    public String getLabel() {
        return this.label;
    }

}
