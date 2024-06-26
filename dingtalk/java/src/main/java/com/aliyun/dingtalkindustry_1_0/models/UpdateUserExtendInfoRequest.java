// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class UpdateUserExtendInfoRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>备注, 当jobStatusCode为其他(0)时, 需要通过该字段补充状态</p>
     */
    @NameInMap("comments")
    public String comments;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("jobCode")
    public String jobCode;

    @NameInMap("jobStatusCode")
    public java.util.List<String> jobStatusCode;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("userProbCode")
    public String userProbCode;

    public static UpdateUserExtendInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateUserExtendInfoRequest self = new UpdateUserExtendInfoRequest();
        return TeaModel.build(map, self);
    }

    public UpdateUserExtendInfoRequest setComments(String comments) {
        this.comments = comments;
        return this;
    }
    public String getComments() {
        return this.comments;
    }

    public UpdateUserExtendInfoRequest setJobCode(String jobCode) {
        this.jobCode = jobCode;
        return this;
    }
    public String getJobCode() {
        return this.jobCode;
    }

    public UpdateUserExtendInfoRequest setJobStatusCode(java.util.List<String> jobStatusCode) {
        this.jobStatusCode = jobStatusCode;
        return this;
    }
    public java.util.List<String> getJobStatusCode() {
        return this.jobStatusCode;
    }

    public UpdateUserExtendInfoRequest setUserProbCode(String userProbCode) {
        this.userProbCode = userProbCode;
        return this;
    }
    public String getUserProbCode() {
        return this.userProbCode;
    }

}
