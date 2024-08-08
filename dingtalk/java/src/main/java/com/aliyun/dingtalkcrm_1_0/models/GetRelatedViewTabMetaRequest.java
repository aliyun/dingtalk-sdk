// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class GetRelatedViewTabMetaRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>PROC-2DB0FF86-CE29-41FF-B0FE-BFDE5BD9A0C1</p>
     */
    @NameInMap("formCode")
    public String formCode;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("viewUserId")
    public String viewUserId;

    public static GetRelatedViewTabMetaRequest build(java.util.Map<String, ?> map) throws Exception {
        GetRelatedViewTabMetaRequest self = new GetRelatedViewTabMetaRequest();
        return TeaModel.build(map, self);
    }

    public GetRelatedViewTabMetaRequest setFormCode(String formCode) {
        this.formCode = formCode;
        return this;
    }
    public String getFormCode() {
        return this.formCode;
    }

    public GetRelatedViewTabMetaRequest setViewUserId(String viewUserId) {
        this.viewUserId = viewUserId;
        return this;
    }
    public String getViewUserId() {
        return this.viewUserId;
    }

}
