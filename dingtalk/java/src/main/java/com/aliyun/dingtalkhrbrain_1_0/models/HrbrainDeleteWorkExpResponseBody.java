// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainDeleteWorkExpResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>480021443f9f37fcbf464c4a6b85d289</p>
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

    public static HrbrainDeleteWorkExpResponseBody build(java.util.Map<String, ?> map) throws Exception {
        HrbrainDeleteWorkExpResponseBody self = new HrbrainDeleteWorkExpResponseBody();
        return TeaModel.build(map, self);
    }

    public HrbrainDeleteWorkExpResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public HrbrainDeleteWorkExpResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

    public HrbrainDeleteWorkExpResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
