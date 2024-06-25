// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class CohostsRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>add</p>
     */
    @NameInMap("action")
    public String action;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userList")
    public java.util.List<CohostsRequestUserList> userList;

    public static CohostsRequest build(java.util.Map<String, ?> map) throws Exception {
        CohostsRequest self = new CohostsRequest();
        return TeaModel.build(map, self);
    }

    public CohostsRequest setAction(String action) {
        this.action = action;
        return this;
    }
    public String getAction() {
        return this.action;
    }

    public CohostsRequest setUserList(java.util.List<CohostsRequestUserList> userList) {
        this.userList = userList;
        return this;
    }
    public java.util.List<CohostsRequestUserList> getUserList() {
        return this.userList;
    }

    public static class CohostsRequestUserList extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>qzR1iSMDvzR9iP7Pxxxxxxxxxxxxxxx</p>
         */
        @NameInMap("unionId")
        public String unionId;

        public static CohostsRequestUserList build(java.util.Map<String, ?> map) throws Exception {
            CohostsRequestUserList self = new CohostsRequestUserList();
            return TeaModel.build(map, self);
        }

        public CohostsRequestUserList setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

    }

}
