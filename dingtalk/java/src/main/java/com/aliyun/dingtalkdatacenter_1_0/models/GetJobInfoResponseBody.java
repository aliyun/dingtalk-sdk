// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetJobInfoResponseBody extends TeaModel {
    /**
     * <p>返回结果</p>
     * <p>EntName:企业名称</p>
     * <p>RecruitingName:职位</p>
     * <p>Description:描述</p>
     * <p>Salary:薪资</p>
     * <p>RecruitingAddress:公司地点</p>
     * <p>Education:学历</p>
     * <p>Experience:工作经验</p>
     * <p>BenefitList:福利</p>
     * <p>PublishDate:发布日期</p>
     * <p>StartDate:招聘开始日期</p>
     * <p>EndDate:招聘截止日期</p>
     * <p>PageUrl:数据源链接</p>
     */
    @NameInMap("data")
    public String data;

    /**
     * <p>总条数</p>
     */
    @NameInMap("total")
    public Long total;

    public static GetJobInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetJobInfoResponseBody self = new GetJobInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetJobInfoResponseBody setData(String data) {
        this.data = data;
        return this;
    }
    public String getData() {
        return this.data;
    }

    public GetJobInfoResponseBody setTotal(Long total) {
        this.total = total;
        return this;
    }
    public Long getTotal() {
        return this.total;
    }

}
