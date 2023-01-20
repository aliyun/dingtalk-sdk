// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetDoubleRandomResponseBody extends TeaModel {
    /**
     * <p>返回结果</p>
     * <p>InspectPlanId:抽查计划编号</p>
     * <p>InspectPlanName:抽查计划名称</p>
     * <p>InspectTaskId:抽查任务编号</p>
     * <p>InspectTaskName:抽查任务名称</p>
     * <p>InspectTypeName:抽查类型</p>
     * <p>InspectDepartment:抽查机关</p>
     * <p>InspectDate:抽查完成时间</p>
     * <p>InspectItem:检查事项</p>
     * <p>InspectResult:检查结果</p>
     */
    @NameInMap("data")
    public String data;

    /**
     * <p>总条数</p>
     */
    @NameInMap("total")
    public Long total;

    public static GetDoubleRandomResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetDoubleRandomResponseBody self = new GetDoubleRandomResponseBody();
        return TeaModel.build(map, self);
    }

    public GetDoubleRandomResponseBody setData(String data) {
        this.data = data;
        return this;
    }
    public String getData() {
        return this.data;
    }

    public GetDoubleRandomResponseBody setTotal(Long total) {
        this.total = total;
        return this;
    }
    public Long getTotal() {
        return this.total;
    }

}
