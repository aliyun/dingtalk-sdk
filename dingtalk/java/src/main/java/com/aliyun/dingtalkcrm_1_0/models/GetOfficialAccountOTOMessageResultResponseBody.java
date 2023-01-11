// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class GetOfficialAccountOTOMessageResultResponseBody extends TeaModel {
    /**
     * <p>Id of the request</p>
     */
    @NameInMap("requestId")
    public String requestId;

    /**
     * <p>查询结果</p>
     */
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
        /**
         * <p>已读消息的userid列表</p>
         */
        @NameInMap("readUserIdList")
        public java.util.List<String> readUserIdList;

        /**
         * <p>执行状态： 0：未开始  1：处理中  2：处理完毕</p>
         */
        @NameInMap("status")
        public Long status;

        public static GetOfficialAccountOTOMessageResultResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetOfficialAccountOTOMessageResultResponseBodyResult self = new GetOfficialAccountOTOMessageResultResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetOfficialAccountOTOMessageResultResponseBodyResult setReadUserIdList(java.util.List<String> readUserIdList) {
            this.readUserIdList = readUserIdList;
            return this;
        }
        public java.util.List<String> getReadUserIdList() {
            return this.readUserIdList;
        }

        public GetOfficialAccountOTOMessageResultResponseBodyResult setStatus(Long status) {
            this.status = status;
            return this;
        }
        public Long getStatus() {
            return this.status;
        }

    }

}
