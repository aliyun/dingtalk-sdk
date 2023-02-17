// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class TransferUserObjectiveResponseBody extends TeaModel {
    /**
     * <p>转交是否成功</p>
     */
    @NameInMap("content")
    public Boolean content;

    /**
     * <p>Id of the request</p>
     */
    @NameInMap("requestId")
    public String requestId;

    /**
     * <p>返回结果</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static TransferUserObjectiveResponseBody build(java.util.Map<String, ?> map) throws Exception {
        TransferUserObjectiveResponseBody self = new TransferUserObjectiveResponseBody();
        return TeaModel.build(map, self);
    }

    public TransferUserObjectiveResponseBody setContent(Boolean content) {
        this.content = content;
        return this;
    }
    public Boolean getContent() {
        return this.content;
    }

    public TransferUserObjectiveResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public TransferUserObjectiveResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
