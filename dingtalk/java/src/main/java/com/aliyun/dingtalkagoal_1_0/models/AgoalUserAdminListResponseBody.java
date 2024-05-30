// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class AgoalUserAdminListResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("content")
    public java.util.List<OpenUserAdminDTO> content;

    @NameInMap("requestId")
    public String requestId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static AgoalUserAdminListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AgoalUserAdminListResponseBody self = new AgoalUserAdminListResponseBody();
        return TeaModel.build(map, self);
    }

    public AgoalUserAdminListResponseBody setContent(java.util.List<OpenUserAdminDTO> content) {
        this.content = content;
        return this;
    }
    public java.util.List<OpenUserAdminDTO> getContent() {
        return this.content;
    }

    public AgoalUserAdminListResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public AgoalUserAdminListResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
