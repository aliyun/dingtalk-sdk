// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainDeleteLabelIndustryResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>480021443f9f37fcbf464c4a6b85d299</p>
     */
    @NameInMap("requestId")
    public String requestId;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("result")
    public Boolean result;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static HrbrainDeleteLabelIndustryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        HrbrainDeleteLabelIndustryResponseBody self = new HrbrainDeleteLabelIndustryResponseBody();
        return TeaModel.build(map, self);
    }

    public HrbrainDeleteLabelIndustryResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public HrbrainDeleteLabelIndustryResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

    public HrbrainDeleteLabelIndustryResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
