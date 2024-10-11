// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class CopyWorkspaceAsyncRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("param")
    public CopyWorkspaceAsyncRequestParam param;

    public static CopyWorkspaceAsyncRequest build(java.util.Map<String, ?> map) throws Exception {
        CopyWorkspaceAsyncRequest self = new CopyWorkspaceAsyncRequest();
        return TeaModel.build(map, self);
    }

    public CopyWorkspaceAsyncRequest setParam(CopyWorkspaceAsyncRequestParam param) {
        this.param = param;
        return this;
    }
    public CopyWorkspaceAsyncRequestParam getParam() {
        return this.param;
    }

    public static class CopyWorkspaceAsyncRequestParam extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>0</p>
         */
        @NameInMap("originWorkspaceId")
        public String originWorkspaceId;

        public static CopyWorkspaceAsyncRequestParam build(java.util.Map<String, ?> map) throws Exception {
            CopyWorkspaceAsyncRequestParam self = new CopyWorkspaceAsyncRequestParam();
            return TeaModel.build(map, self);
        }

        public CopyWorkspaceAsyncRequestParam setOriginWorkspaceId(String originWorkspaceId) {
            this.originWorkspaceId = originWorkspaceId;
            return this;
        }
        public String getOriginWorkspaceId() {
            return this.originWorkspaceId;
        }

    }

}
