// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class AgoalUserSubAdminListResponseBody extends TeaModel {
    @NameInMap("content")
    public java.util.List<OpenUserSubAdminDTO> content;

    /**
     * <strong>example:</strong>
     * <p>7478B23C-80E8-1AD6-BE8C-09D480E0xxxx</p>
     */
    @NameInMap("requestId")
    public String requestId;

    @NameInMap("success")
    public Boolean success;

    public static AgoalUserSubAdminListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AgoalUserSubAdminListResponseBody self = new AgoalUserSubAdminListResponseBody();
        return TeaModel.build(map, self);
    }

    public AgoalUserSubAdminListResponseBody setContent(java.util.List<OpenUserSubAdminDTO> content) {
        this.content = content;
        return this;
    }
    public java.util.List<OpenUserSubAdminDTO> getContent() {
        return this.content;
    }

    public AgoalUserSubAdminListResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public AgoalUserSubAdminListResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
