// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class AgoalFiscalYearschemeListResponseBody extends TeaModel {
    @NameInMap("content")
    public java.util.List<OpenFiscalYearSchemeDTO> content;

    @NameInMap("success")
    public Boolean success;

    @NameInMap("traceId")
    public String traceId;

    public static AgoalFiscalYearschemeListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AgoalFiscalYearschemeListResponseBody self = new AgoalFiscalYearschemeListResponseBody();
        return TeaModel.build(map, self);
    }

    public AgoalFiscalYearschemeListResponseBody setContent(java.util.List<OpenFiscalYearSchemeDTO> content) {
        this.content = content;
        return this;
    }
    public java.util.List<OpenFiscalYearSchemeDTO> getContent() {
        return this.content;
    }

    public AgoalFiscalYearschemeListResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public AgoalFiscalYearschemeListResponseBody setTraceId(String traceId) {
        this.traceId = traceId;
        return this;
    }
    public String getTraceId() {
        return this.traceId;
    }

}
