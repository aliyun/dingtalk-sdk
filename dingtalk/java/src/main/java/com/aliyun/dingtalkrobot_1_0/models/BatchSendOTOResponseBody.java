// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class BatchSendOTOResponseBody extends TeaModel {
    @NameInMap("filteredStaffIdList")
    public java.util.List<String> filteredStaffIdList;

    @NameInMap("flowControlledStaffIdList")
    public java.util.List<String> flowControlledStaffIdList;

    @NameInMap("invalidStaffIdList")
    public java.util.List<String> invalidStaffIdList;

    @NameInMap("processQueryKey")
    public String processQueryKey;

    public static BatchSendOTOResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchSendOTOResponseBody self = new BatchSendOTOResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchSendOTOResponseBody setFilteredStaffIdList(java.util.List<String> filteredStaffIdList) {
        this.filteredStaffIdList = filteredStaffIdList;
        return this;
    }
    public java.util.List<String> getFilteredStaffIdList() {
        return this.filteredStaffIdList;
    }

    public BatchSendOTOResponseBody setFlowControlledStaffIdList(java.util.List<String> flowControlledStaffIdList) {
        this.flowControlledStaffIdList = flowControlledStaffIdList;
        return this;
    }
    public java.util.List<String> getFlowControlledStaffIdList() {
        return this.flowControlledStaffIdList;
    }

    public BatchSendOTOResponseBody setInvalidStaffIdList(java.util.List<String> invalidStaffIdList) {
        this.invalidStaffIdList = invalidStaffIdList;
        return this;
    }
    public java.util.List<String> getInvalidStaffIdList() {
        return this.invalidStaffIdList;
    }

    public BatchSendOTOResponseBody setProcessQueryKey(String processQueryKey) {
        this.processQueryKey = processQueryKey;
        return this;
    }
    public String getProcessQueryKey() {
        return this.processQueryKey;
    }

}
