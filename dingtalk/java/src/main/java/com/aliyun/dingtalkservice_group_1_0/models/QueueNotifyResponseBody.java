// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class QueueNotifyResponseBody extends TeaModel {
    // dingOpenErrcode
    @NameInMap("dingOpenErrcode")
    public Integer dingOpenErrcode;

    // errorMsg
    @NameInMap("errorMsg")
    public String errorMsg;

    // 执行是否成功
    @NameInMap("result")
    public Boolean result;

    // 回调是否成功
    @NameInMap("success")
    public Boolean success;

    public static QueueNotifyResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueueNotifyResponseBody self = new QueueNotifyResponseBody();
        return TeaModel.build(map, self);
    }

    public QueueNotifyResponseBody setDingOpenErrcode(Integer dingOpenErrcode) {
        this.dingOpenErrcode = dingOpenErrcode;
        return this;
    }
    public Integer getDingOpenErrcode() {
        return this.dingOpenErrcode;
    }

    public QueueNotifyResponseBody setErrorMsg(String errorMsg) {
        this.errorMsg = errorMsg;
        return this;
    }
    public String getErrorMsg() {
        return this.errorMsg;
    }

    public QueueNotifyResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

    public QueueNotifyResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
