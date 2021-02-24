// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkapp_market_1_0.models;

import com.aliyun.tea.*;

public class UserTaskReportRequest extends TeaModel {
    @NameInMap("dingCorpId")
    public String dingCorpId;

    // taskTag
    @NameInMap("taskTag")
    public String taskTag;

    // operateDate
    @NameInMap("operateDate")
    public String operateDate;

    // staffId
    @NameInMap("userid")
    public String userid;

    // 业务的幂等ID
    @NameInMap("bizNo")
    public String bizNo;

    public static UserTaskReportRequest build(java.util.Map<String, ?> map) throws Exception {
        UserTaskReportRequest self = new UserTaskReportRequest();
        return TeaModel.build(map, self);
    }

    public UserTaskReportRequest setDingCorpId(String dingCorpId) {
        this.dingCorpId = dingCorpId;
        return this;
    }
    public String getDingCorpId() {
        return this.dingCorpId;
    }

    public UserTaskReportRequest setTaskTag(String taskTag) {
        this.taskTag = taskTag;
        return this;
    }
    public String getTaskTag() {
        return this.taskTag;
    }

    public UserTaskReportRequest setOperateDate(String operateDate) {
        this.operateDate = operateDate;
        return this;
    }
    public String getOperateDate() {
        return this.operateDate;
    }

    public UserTaskReportRequest setUserid(String userid) {
        this.userid = userid;
        return this;
    }
    public String getUserid() {
        return this.userid;
    }

    public UserTaskReportRequest setBizNo(String bizNo) {
        this.bizNo = bizNo;
        return this;
    }
    public String getBizNo() {
        return this.bizNo;
    }

}
