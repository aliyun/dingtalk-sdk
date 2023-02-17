// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class ListProgressByIdsResponseBody extends TeaModel {
    @NameInMap("content")
    public java.util.List<OpenProgressDTO> content;

    /**
     * <p>Id of the request</p>
     */
    @NameInMap("requestId")
    public String requestId;

    @NameInMap("success")
    public Boolean success;

    public static ListProgressByIdsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListProgressByIdsResponseBody self = new ListProgressByIdsResponseBody();
        return TeaModel.build(map, self);
    }

    public ListProgressByIdsResponseBody setContent(java.util.List<OpenProgressDTO> content) {
        this.content = content;
        return this;
    }
    public java.util.List<OpenProgressDTO> getContent() {
        return this.content;
    }

    public ListProgressByIdsResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public ListProgressByIdsResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
