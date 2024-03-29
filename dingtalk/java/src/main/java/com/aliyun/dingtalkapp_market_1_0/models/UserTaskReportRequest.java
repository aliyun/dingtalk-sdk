// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkapp_market_1_0.models;

import com.aliyun.tea.*;

public class UserTaskReportRequest extends TeaModel {
    @NameInMap("bizNo")
    public String bizNo;

    @NameInMap("operateDate")
    public String operateDate;

    @NameInMap("taskTag")
    public String taskTag;

    @NameInMap("userid")
    public String userid;

    public static UserTaskReportRequest build(java.util.Map<String, ?> map) throws Exception {
        UserTaskReportRequest self = new UserTaskReportRequest();
        return TeaModel.build(map, self);
    }

    public UserTaskReportRequest setBizNo(String bizNo) {
        this.bizNo = bizNo;
        return this;
    }
    public String getBizNo() {
        return this.bizNo;
    }

    public UserTaskReportRequest setOperateDate(String operateDate) {
        this.operateDate = operateDate;
        return this;
    }
    public String getOperateDate() {
        return this.operateDate;
    }

    public UserTaskReportRequest setTaskTag(String taskTag) {
        this.taskTag = taskTag;
        return this;
    }
    public String getTaskTag() {
        return this.taskTag;
    }

    public UserTaskReportRequest setUserid(String userid) {
        this.userid = userid;
        return this;
    }
    public String getUserid() {
        return this.userid;
    }

}
