// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class HandoveryWorkspaceRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("param")
    public HandoveryWorkspaceRequestParam param;

    public static HandoveryWorkspaceRequest build(java.util.Map<String, ?> map) throws Exception {
        HandoveryWorkspaceRequest self = new HandoveryWorkspaceRequest();
        return TeaModel.build(map, self);
    }

    public HandoveryWorkspaceRequest setParam(HandoveryWorkspaceRequestParam param) {
        this.param = param;
        return this;
    }
    public HandoveryWorkspaceRequestParam getParam() {
        return this.param;
    }

    public static class HandoveryWorkspaceRequestParam extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>unionId</p>
         */
        @NameInMap("leave")
        public Boolean leave;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>unionId</p>
         */
        @NameInMap("receiverUnionId")
        public String receiverUnionId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>root_node_uuid</p>
         */
        @NameInMap("resourceId")
        public String resourceId;

        public static HandoveryWorkspaceRequestParam build(java.util.Map<String, ?> map) throws Exception {
            HandoveryWorkspaceRequestParam self = new HandoveryWorkspaceRequestParam();
            return TeaModel.build(map, self);
        }

        public HandoveryWorkspaceRequestParam setLeave(Boolean leave) {
            this.leave = leave;
            return this;
        }
        public Boolean getLeave() {
            return this.leave;
        }

        public HandoveryWorkspaceRequestParam setReceiverUnionId(String receiverUnionId) {
            this.receiverUnionId = receiverUnionId;
            return this;
        }
        public String getReceiverUnionId() {
            return this.receiverUnionId;
        }

        public HandoveryWorkspaceRequestParam setResourceId(String resourceId) {
            this.resourceId = resourceId;
            return this;
        }
        public String getResourceId() {
            return this.resourceId;
        }

    }

}
