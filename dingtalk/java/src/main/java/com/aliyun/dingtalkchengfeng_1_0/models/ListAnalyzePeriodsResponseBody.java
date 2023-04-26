// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class ListAnalyzePeriodsResponseBody extends TeaModel {
    @NameInMap("content")
    public java.util.List<OpenPeriodDTO> content;

    @NameInMap("requestId")
    public String requestId;

    @NameInMap("success")
    public Boolean success;

    public static ListAnalyzePeriodsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListAnalyzePeriodsResponseBody self = new ListAnalyzePeriodsResponseBody();
        return TeaModel.build(map, self);
    }

    public ListAnalyzePeriodsResponseBody setContent(java.util.List<OpenPeriodDTO> content) {
        this.content = content;
        return this;
    }
    public java.util.List<OpenPeriodDTO> getContent() {
        return this.content;
    }

    public ListAnalyzePeriodsResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public ListAnalyzePeriodsResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
