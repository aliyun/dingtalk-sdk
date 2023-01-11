// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class GetSpaceWithDownloadAuthResponseBody extends TeaModel {
    /**
     * <p>返回结果。</p>
     */
    @NameInMap("result")
    public GetSpaceWithDownloadAuthResponseBodyResult result;

    /**
     * <p>接口调用是否成功。</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static GetSpaceWithDownloadAuthResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetSpaceWithDownloadAuthResponseBody self = new GetSpaceWithDownloadAuthResponseBody();
        return TeaModel.build(map, self);
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
        /**
         * <p>钉盘空间ID。</p>
         */
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
