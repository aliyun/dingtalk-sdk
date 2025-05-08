// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class BatchUpdateExternalTitleRequest extends TeaModel {
    @NameInMap("operatorUserId")
    public String operatorUserId;

    @NameInMap("updateTitleModelList")
    public java.util.List<BatchUpdateExternalTitleRequestUpdateTitleModelList> updateTitleModelList;

    public static BatchUpdateExternalTitleRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchUpdateExternalTitleRequest self = new BatchUpdateExternalTitleRequest();
        return TeaModel.build(map, self);
    }

    public BatchUpdateExternalTitleRequest setOperatorUserId(String operatorUserId) {
        this.operatorUserId = operatorUserId;
        return this;
    }
    public String getOperatorUserId() {
        return this.operatorUserId;
    }

    public BatchUpdateExternalTitleRequest setUpdateTitleModelList(java.util.List<BatchUpdateExternalTitleRequestUpdateTitleModelList> updateTitleModelList) {
        this.updateTitleModelList = updateTitleModelList;
        return this;
    }
    public java.util.List<BatchUpdateExternalTitleRequestUpdateTitleModelList> getUpdateTitleModelList() {
        return this.updateTitleModelList;
    }

    public static class BatchUpdateExternalTitleRequestUpdateTitleModelList extends TeaModel {
        @NameInMap("title")
        public String title;

        @NameInMap("userId")
        public String userId;

        public static BatchUpdateExternalTitleRequestUpdateTitleModelList build(java.util.Map<String, ?> map) throws Exception {
            BatchUpdateExternalTitleRequestUpdateTitleModelList self = new BatchUpdateExternalTitleRequestUpdateTitleModelList();
            return TeaModel.build(map, self);
        }

        public BatchUpdateExternalTitleRequestUpdateTitleModelList setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public BatchUpdateExternalTitleRequestUpdateTitleModelList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
