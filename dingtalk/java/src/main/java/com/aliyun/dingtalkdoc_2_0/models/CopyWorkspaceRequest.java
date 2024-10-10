// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class CopyWorkspaceRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("param")
    public CopyWorkspaceRequestParam param;

    public static CopyWorkspaceRequest build(java.util.Map<String, ?> map) throws Exception {
        CopyWorkspaceRequest self = new CopyWorkspaceRequest();
        return TeaModel.build(map, self);
    }

    public CopyWorkspaceRequest setParam(CopyWorkspaceRequestParam param) {
        this.param = param;
        return this;
    }
    public CopyWorkspaceRequestParam getParam() {
        return this.param;
    }

    public static class CopyWorkspaceRequestParam extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>0</p>
         */
        @NameInMap("originWorkspaceId")
        public String originWorkspaceId;

        public static CopyWorkspaceRequestParam build(java.util.Map<String, ?> map) throws Exception {
            CopyWorkspaceRequestParam self = new CopyWorkspaceRequestParam();
            return TeaModel.build(map, self);
        }

        public CopyWorkspaceRequestParam setOriginWorkspaceId(String originWorkspaceId) {
            this.originWorkspaceId = originWorkspaceId;
            return this;
        }
        public String getOriginWorkspaceId() {
            return this.originWorkspaceId;
        }

    }

}
