// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class AddLeadsRequest extends TeaModel {
    @NameInMap("assignTimestamp")
    public Long assignTimestamp;

    @NameInMap("assignUserId")
    public String assignUserId;

    @NameInMap("assignedUserId")
    public String assignedUserId;

    @NameInMap("leads")
    public java.util.List<AddLeadsRequestLeads> leads;

    @NameInMap("outTaskId")
    public String outTaskId;

    public static AddLeadsRequest build(java.util.Map<String, ?> map) throws Exception {
        AddLeadsRequest self = new AddLeadsRequest();
        return TeaModel.build(map, self);
    }

    public AddLeadsRequest setAssignTimestamp(Long assignTimestamp) {
        this.assignTimestamp = assignTimestamp;
        return this;
    }
    public Long getAssignTimestamp() {
        return this.assignTimestamp;
    }

    public AddLeadsRequest setAssignUserId(String assignUserId) {
        this.assignUserId = assignUserId;
        return this;
    }
    public String getAssignUserId() {
        return this.assignUserId;
    }

    public AddLeadsRequest setAssignedUserId(String assignedUserId) {
        this.assignedUserId = assignedUserId;
        return this;
    }
    public String getAssignedUserId() {
        return this.assignedUserId;
    }

    public AddLeadsRequest setLeads(java.util.List<AddLeadsRequestLeads> leads) {
        this.leads = leads;
        return this;
    }
    public java.util.List<AddLeadsRequestLeads> getLeads() {
        return this.leads;
    }

    public AddLeadsRequest setOutTaskId(String outTaskId) {
        this.outTaskId = outTaskId;
        return this;
    }
    public String getOutTaskId() {
        return this.outTaskId;
    }

    public static class AddLeadsRequestLeads extends TeaModel {
        @NameInMap("leadsName")
        public String leadsName;

        @NameInMap("outLeadsId")
        public String outLeadsId;

        public static AddLeadsRequestLeads build(java.util.Map<String, ?> map) throws Exception {
            AddLeadsRequestLeads self = new AddLeadsRequestLeads();
            return TeaModel.build(map, self);
        }

        public AddLeadsRequestLeads setLeadsName(String leadsName) {
            this.leadsName = leadsName;
            return this;
        }
        public String getLeadsName() {
            return this.leadsName;
        }

        public AddLeadsRequestLeads setOutLeadsId(String outLeadsId) {
            this.outLeadsId = outLeadsId;
            return this;
        }
        public String getOutLeadsId() {
            return this.outLeadsId;
        }

    }

}
