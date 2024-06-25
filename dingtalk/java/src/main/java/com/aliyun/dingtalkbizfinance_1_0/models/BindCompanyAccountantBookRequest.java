// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class BindCompanyAccountantBookRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>abc</p>
     */
    @NameInMap("accountantBookId")
    public String accountantBookId;

    /**
     * <strong>example:</strong>
     * <p>COM_DEFAULT</p>
     */
    @NameInMap("companyCode")
    public String companyCode;

    public static BindCompanyAccountantBookRequest build(java.util.Map<String, ?> map) throws Exception {
        BindCompanyAccountantBookRequest self = new BindCompanyAccountantBookRequest();
        return TeaModel.build(map, self);
    }

    public BindCompanyAccountantBookRequest setAccountantBookId(String accountantBookId) {
        this.accountantBookId = accountantBookId;
        return this;
    }
    public String getAccountantBookId() {
        return this.accountantBookId;
    }

    public BindCompanyAccountantBookRequest setCompanyCode(String companyCode) {
        this.companyCode = companyCode;
        return this;
    }
    public String getCompanyCode() {
        return this.companyCode;
    }

}
