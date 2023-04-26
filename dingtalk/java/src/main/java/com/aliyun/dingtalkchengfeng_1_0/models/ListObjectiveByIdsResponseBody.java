// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class ListObjectiveByIdsResponseBody extends TeaModel {
    @NameInMap("content")
    public java.util.List<OpenObjectiveDTO> content;

    @NameInMap("requestId")
    public String requestId;

    @NameInMap("success")
    public Boolean success;

    public static ListObjectiveByIdsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListObjectiveByIdsResponseBody self = new ListObjectiveByIdsResponseBody();
        return TeaModel.build(map, self);
    }

    public ListObjectiveByIdsResponseBody setContent(java.util.List<OpenObjectiveDTO> content) {
        this.content = content;
        return this;
    }
    public java.util.List<OpenObjectiveDTO> getContent() {
        return this.content;
    }

    public ListObjectiveByIdsResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public ListObjectiveByIdsResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
