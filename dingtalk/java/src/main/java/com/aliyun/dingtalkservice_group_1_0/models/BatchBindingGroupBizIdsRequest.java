// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class BatchBindingGroupBizIdsRequest extends TeaModel {
    @NameInMap("bindingGroupBizIds")
    public java.util.List<BatchBindingGroupBizIdsRequestBindingGroupBizIds> bindingGroupBizIds;

    /**
     * <p>开放团队ID</p>
     */
    @NameInMap("openTeamId")
    public String openTeamId;

    public static BatchBindingGroupBizIdsRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchBindingGroupBizIdsRequest self = new BatchBindingGroupBizIdsRequest();
        return TeaModel.build(map, self);
    }

    public BatchBindingGroupBizIdsRequest setBindingGroupBizIds(java.util.List<BatchBindingGroupBizIdsRequestBindingGroupBizIds> bindingGroupBizIds) {
        this.bindingGroupBizIds = bindingGroupBizIds;
        return this;
    }
    public java.util.List<BatchBindingGroupBizIdsRequestBindingGroupBizIds> getBindingGroupBizIds() {
        return this.bindingGroupBizIds;
    }

    public BatchBindingGroupBizIdsRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

    public static class BatchBindingGroupBizIdsRequestBindingGroupBizIds extends TeaModel {
        /**
         * <p>业务ID</p>
         */
        @NameInMap("bizId")
        public String bizId;

        /**
         * <p>群会话ID</p>
         */
        @NameInMap("openConversationId")
        public String openConversationId;

        public static BatchBindingGroupBizIdsRequestBindingGroupBizIds build(java.util.Map<String, ?> map) throws Exception {
            BatchBindingGroupBizIdsRequestBindingGroupBizIds self = new BatchBindingGroupBizIdsRequestBindingGroupBizIds();
            return TeaModel.build(map, self);
        }

        public BatchBindingGroupBizIdsRequestBindingGroupBizIds setBizId(String bizId) {
            this.bizId = bizId;
            return this;
        }
        public String getBizId() {
            return this.bizId;
        }

        public BatchBindingGroupBizIdsRequestBindingGroupBizIds setOpenConversationId(String openConversationId) {
            this.openConversationId = openConversationId;
            return this;
        }
        public String getOpenConversationId() {
            return this.openConversationId;
        }

    }

}
