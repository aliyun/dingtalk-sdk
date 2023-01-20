// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetSoftwareCopyrightResponseBody extends TeaModel {
    /**
     * <p>返回结果</p>
     * <p>EntName:企业名称</p>
     * <p>CopyNum:登记号</p>
     * <p>TypeNum:分类号</p>
     * <p>ShortName:作品简称</p>
     * <p>CopyName:作品全称</p>
     * <p>Version:版本号</p>
     * <p>SuccessDate:创作完成日期</p>
     * <p>FirstDate:首次发表日期</p>
     * <p>ApprovalDate:登记批准日期</p>
     */
    @NameInMap("data")
    public String data;

    /**
     * <p>总条数</p>
     */
    @NameInMap("total")
    public Long total;

    public static GetSoftwareCopyrightResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetSoftwareCopyrightResponseBody self = new GetSoftwareCopyrightResponseBody();
        return TeaModel.build(map, self);
    }

    public GetSoftwareCopyrightResponseBody setData(String data) {
        this.data = data;
        return this;
    }
    public String getData() {
        return this.data;
    }

    public GetSoftwareCopyrightResponseBody setTotal(Long total) {
        this.total = total;
        return this;
    }
    public Long getTotal() {
        return this.total;
    }

}
