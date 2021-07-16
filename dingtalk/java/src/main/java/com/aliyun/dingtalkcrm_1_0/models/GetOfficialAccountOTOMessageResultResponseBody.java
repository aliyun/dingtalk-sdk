// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class GetOfficialAccountOTOMessageResultResponseBody extends TeaModel {
    // Id of the request
    @NameInMap("requestId")
    public String requestId;

    // 查询结果
    @NameInMap("result")
    public GetOfficialAccountOTOMessageResultResponseBodyResult result;

    public static GetOfficialAccountOTOMessageResultResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetOfficialAccountOTOMessageResultResponseBody self = new GetOfficialAccountOTOMessageResultResponseBody();
        return TeaModel.build(map, self);
    }

    public GetOfficialAccountOTOMessageResultResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public GetOfficialAccountOTOMessageResultResponseBody setResult(GetOfficialAccountOTOMessageResultResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetOfficialAccountOTOMessageResultResponseBodyResult getResult() {
        return this.result;
    }

    public static class GetOfficialAccountOTOMessageResultResponseBodyResult extends TeaModel {
        // 执行状态： 0：未开始  1：处理中  2：处理完毕
        @NameInMap("status")
        public Long status;

        // 已读消息的userid列表
        @NameInMap("readUserIdList")
        public java.util.List<String> readUserIdList;

        public static GetOfficialAccountOTOMessageResultResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetOfficialAccountOTOMessageResultResponseBodyResult self = new GetOfficialAccountOTOMessageResultResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetOfficialAccountOTOMessageResultResponseBodyResult setStatus(Long status) {
            this.status = status;
            return this;
        }
        public Long getStatus() {
            return this.status;
        }

        public GetOfficialAccountOTOMessageResultResponseBodyResult setReadUserIdList(java.util.List<String> readUserIdList) {
            this.readUserIdList = readUserIdList;
            return this;
        }
        public java.util.List<String> getReadUserIdList() {
            return this.readUserIdList;
        }

    }

}
