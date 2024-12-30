// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class UpdateInvoiceUrlResponseBody extends TeaModel {
    @NameInMap("result")
    public UpdateInvoiceUrlResponseBodyResult result;

    public static UpdateInvoiceUrlResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateInvoiceUrlResponseBody self = new UpdateInvoiceUrlResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateInvoiceUrlResponseBody setResult(UpdateInvoiceUrlResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public UpdateInvoiceUrlResponseBodyResult getResult() {
        return this.result;
    }

    public static class UpdateInvoiceUrlResponseBodyResultFailInvoiceList extends TeaModel {
        @NameInMap("errorMsg")
        public String errorMsg;

        @NameInMap("invoiceCode")
        public String invoiceCode;

        @NameInMap("invoiceNo")
        public String invoiceNo;

        public static UpdateInvoiceUrlResponseBodyResultFailInvoiceList build(java.util.Map<String, ?> map) throws Exception {
            UpdateInvoiceUrlResponseBodyResultFailInvoiceList self = new UpdateInvoiceUrlResponseBodyResultFailInvoiceList();
            return TeaModel.build(map, self);
        }

        public UpdateInvoiceUrlResponseBodyResultFailInvoiceList setErrorMsg(String errorMsg) {
            this.errorMsg = errorMsg;
            return this;
        }
        public String getErrorMsg() {
            return this.errorMsg;
        }

        public UpdateInvoiceUrlResponseBodyResultFailInvoiceList setInvoiceCode(String invoiceCode) {
            this.invoiceCode = invoiceCode;
            return this;
        }
        public String getInvoiceCode() {
            return this.invoiceCode;
        }

        public UpdateInvoiceUrlResponseBodyResultFailInvoiceList setInvoiceNo(String invoiceNo) {
            this.invoiceNo = invoiceNo;
            return this;
        }
        public String getInvoiceNo() {
            return this.invoiceNo;
        }

    }

    public static class UpdateInvoiceUrlResponseBodyResult extends TeaModel {
        @NameInMap("failInvoiceList")
        public java.util.List<UpdateInvoiceUrlResponseBodyResultFailInvoiceList> failInvoiceList;

        @NameInMap("isAllSuccess")
        public String isAllSuccess;

        public static UpdateInvoiceUrlResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            UpdateInvoiceUrlResponseBodyResult self = new UpdateInvoiceUrlResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public UpdateInvoiceUrlResponseBodyResult setFailInvoiceList(java.util.List<UpdateInvoiceUrlResponseBodyResultFailInvoiceList> failInvoiceList) {
            this.failInvoiceList = failInvoiceList;
            return this;
        }
        public java.util.List<UpdateInvoiceUrlResponseBodyResultFailInvoiceList> getFailInvoiceList() {
            return this.failInvoiceList;
        }

        public UpdateInvoiceUrlResponseBodyResult setIsAllSuccess(String isAllSuccess) {
            this.isAllSuccess = isAllSuccess;
            return this;
        }
        public String getIsAllSuccess() {
            return this.isAllSuccess;
        }

    }

}
