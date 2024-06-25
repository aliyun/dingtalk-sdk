// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkbench_1_0.models;

import com.aliyun.tea.*;

public class AddRecentUserAppListRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>ding48143d56cd15327624f2f5cc6abecb85</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("usedAppDetailList")
    public java.util.List<AddRecentUserAppListRequestUsedAppDetailList> usedAppDetailList;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>642325391030949</p>
     */
    @NameInMap("userId")
    public String userId;

    public static AddRecentUserAppListRequest build(java.util.Map<String, ?> map) throws Exception {
        AddRecentUserAppListRequest self = new AddRecentUserAppListRequest();
        return TeaModel.build(map, self);
    }

    public AddRecentUserAppListRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public AddRecentUserAppListRequest setUsedAppDetailList(java.util.List<AddRecentUserAppListRequestUsedAppDetailList> usedAppDetailList) {
        this.usedAppDetailList = usedAppDetailList;
        return this;
    }
    public java.util.List<AddRecentUserAppListRequestUsedAppDetailList> getUsedAppDetailList() {
        return this.usedAppDetailList;
    }

    public AddRecentUserAppListRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public static class AddRecentUserAppListRequestUsedAppDetailList extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>2636835622</p>
         */
        @NameInMap("agentId")
        public String agentId;

        public static AddRecentUserAppListRequestUsedAppDetailList build(java.util.Map<String, ?> map) throws Exception {
            AddRecentUserAppListRequestUsedAppDetailList self = new AddRecentUserAppListRequestUsedAppDetailList();
            return TeaModel.build(map, self);
        }

        public AddRecentUserAppListRequestUsedAppDetailList setAgentId(String agentId) {
            this.agentId = agentId;
            return this;
        }
        public String getAgentId() {
            return this.agentId;
        }

    }

}
