// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktranscribe_1_0.models;

import com.aliyun.tea.*;

public class RemovePermissionResponseBody extends TeaModel {
    /**
     * <p>当执行出错的时候，移除权限失败的用户昵称列表</p>
     */
    @NameInMap("data")
    public RemovePermissionResponseBodyData data;

    /**
     * <p>服务端返回的错误代码</p>
     */
    @NameInMap("statusCode")
    public Integer statusCode;

    /**
     * <p>描述本次调用的业务层面是否成功</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static RemovePermissionResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RemovePermissionResponseBody self = new RemovePermissionResponseBody();
        return TeaModel.build(map, self);
    }

    public RemovePermissionResponseBody setData(RemovePermissionResponseBodyData data) {
        this.data = data;
        return this;
    }
    public RemovePermissionResponseBodyData getData() {
        return this.data;
    }

    public RemovePermissionResponseBody setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public RemovePermissionResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class RemovePermissionResponseBodyData extends TeaModel {
        @NameInMap("failNameList")
        public java.util.List<String> failNameList;

        public static RemovePermissionResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            RemovePermissionResponseBodyData self = new RemovePermissionResponseBodyData();
            return TeaModel.build(map, self);
        }

        public RemovePermissionResponseBodyData setFailNameList(java.util.List<String> failNameList) {
            this.failNameList = failNameList;
            return this;
        }
        public java.util.List<String> getFailNameList() {
            return this.failNameList;
        }

    }

}
