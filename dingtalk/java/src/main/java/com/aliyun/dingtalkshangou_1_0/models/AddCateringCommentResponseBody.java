// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkshangou_1_0.models;

import com.aliyun.tea.*;

public class AddCateringCommentResponseBody extends TeaModel {
    @NameInMap("errorCode")
    public String errorCode;

    @NameInMap("errorMsg")
    public String errorMsg;

    @NameInMap("result")
    public String result;

    @NameInMap("success")
    public Boolean success;

    public static AddCateringCommentResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddCateringCommentResponseBody self = new AddCateringCommentResponseBody();
        return TeaModel.build(map, self);
    }

    public AddCateringCommentResponseBody setErrorCode(String errorCode) {
        this.errorCode = errorCode;
        return this;
    }
    public String getErrorCode() {
        return this.errorCode;
    }

    public AddCateringCommentResponseBody setErrorMsg(String errorMsg) {
        this.errorMsg = errorMsg;
        return this;
    }
    public String getErrorMsg() {
        return this.errorMsg;
    }

    public AddCateringCommentResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

    public AddCateringCommentResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
