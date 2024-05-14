// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkapp_market_1_0.models;

import com.aliyun.tea.*;

public class UserTaskReportRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("bizNo")
    public String bizNo;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("operateDate")
    public String operateDate;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("taskTag")
    public String taskTag;

    /**
     * <p>This parameter is required.</p>
     */
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
