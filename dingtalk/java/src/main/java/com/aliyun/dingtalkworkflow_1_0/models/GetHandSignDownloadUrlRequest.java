// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class GetHandSignDownloadUrlRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>AzBltRlvKukX3Wxxxx</p>
     */
    @NameInMap("handSignToken")
    public String handSignToken;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>ag187wewxxxx</p>
     */
    @NameInMap("processInstanceId")
    public String processInstanceId;

    public static GetHandSignDownloadUrlRequest build(java.util.Map<String, ?> map) throws Exception {
        GetHandSignDownloadUrlRequest self = new GetHandSignDownloadUrlRequest();
        return TeaModel.build(map, self);
    }

    public GetHandSignDownloadUrlRequest setHandSignToken(String handSignToken) {
        this.handSignToken = handSignToken;
        return this;
    }
    public String getHandSignToken() {
        return this.handSignToken;
    }

    public GetHandSignDownloadUrlRequest setProcessInstanceId(String processInstanceId) {
        this.processInstanceId = processInstanceId;
        return this;
    }
    public String getProcessInstanceId() {
        return this.processInstanceId;
    }

}
