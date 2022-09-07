// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class GetSpaceWithDownloadAuthResponseBody extends TeaModel {
    // 请求ID。
    @NameInMap("requestId")
    public String requestId;

    // 返回结果。
    @NameInMap("result")
    public GetSpaceWithDownloadAuthResponseBodyResult result;

    // 接口调用是否成功。
    @NameInMap("success")
    public Boolean success;

    public static GetSpaceWithDownloadAuthResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetSpaceWithDownloadAuthResponseBody self = new GetSpaceWithDownloadAuthResponseBody();
        return TeaModel.build(map, self);
    }

    public GetSpaceWithDownloadAuthResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public GetSpaceWithDownloadAuthResponseBody setResult(GetSpaceWithDownloadAuthResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetSpaceWithDownloadAuthResponseBodyResult getResult() {
        return this.result;
    }

    public GetSpaceWithDownloadAuthResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class GetSpaceWithDownloadAuthResponseBodyResult extends TeaModel {
        // 钉盘空间ID。
        @NameInMap("spaceId")
        public Long spaceId;

        public static GetSpaceWithDownloadAuthResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetSpaceWithDownloadAuthResponseBodyResult self = new GetSpaceWithDownloadAuthResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetSpaceWithDownloadAuthResponseBodyResult setSpaceId(Long spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public Long getSpaceId() {
            return this.spaceId;
        }

    }

}
