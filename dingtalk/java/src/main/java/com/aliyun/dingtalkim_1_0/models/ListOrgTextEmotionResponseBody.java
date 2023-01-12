// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class ListOrgTextEmotionResponseBody extends TeaModel {
    /**
     * <p>拉取企业文字表情结果</p>
     */
    @NameInMap("result")
    public ListOrgTextEmotionResponseBodyResult result;

    /**
     * <p>返回结果</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static ListOrgTextEmotionResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListOrgTextEmotionResponseBody self = new ListOrgTextEmotionResponseBody();
        return TeaModel.build(map, self);
    }

    public ListOrgTextEmotionResponseBody setResult(ListOrgTextEmotionResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public ListOrgTextEmotionResponseBodyResult getResult() {
        return this.result;
    }

    public ListOrgTextEmotionResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class ListOrgTextEmotionResponseBodyResultEmotions extends TeaModel {
        /**
         * <p>展示在消息气泡中的文字表情的mediaId</p>
         */
        @NameInMap("backgroundMediaId")
        public String backgroundMediaId;

        /**
         * <p>展示在消息长按菜单中的文字表情的mediaId</p>
         */
        @NameInMap("backgroundMediaIdForPanel")
        public String backgroundMediaIdForPanel;

        /**
         * <p>表情所属部门Id：</p>
         * <p>-1：该表情为企业层面的文字表情</p>
         * <p>一级部门Id：该表情为一级部门层面的文字表情</p>
         */
        @NameInMap("deptId")
        public Long deptId;

        /**
         * <p>表情Id</p>
         */
        @NameInMap("emotionId")
        public String emotionId;

        /**
         * <p>表情名称，对用户不可见</p>
         */
        @NameInMap("emotionName")
        public String emotionName;

        /**
         * <p>表情状态</p>
         * <p>0：已删除</p>
         * <p>1：可用</p>
         * <p>2：安全审核不通过</p>
         */
        @NameInMap("status")
        public Integer status;

        public static ListOrgTextEmotionResponseBodyResultEmotions build(java.util.Map<String, ?> map) throws Exception {
            ListOrgTextEmotionResponseBodyResultEmotions self = new ListOrgTextEmotionResponseBodyResultEmotions();
            return TeaModel.build(map, self);
        }

        public ListOrgTextEmotionResponseBodyResultEmotions setBackgroundMediaId(String backgroundMediaId) {
            this.backgroundMediaId = backgroundMediaId;
            return this;
        }
        public String getBackgroundMediaId() {
            return this.backgroundMediaId;
        }

        public ListOrgTextEmotionResponseBodyResultEmotions setBackgroundMediaIdForPanel(String backgroundMediaIdForPanel) {
            this.backgroundMediaIdForPanel = backgroundMediaIdForPanel;
            return this;
        }
        public String getBackgroundMediaIdForPanel() {
            return this.backgroundMediaIdForPanel;
        }

        public ListOrgTextEmotionResponseBodyResultEmotions setDeptId(Long deptId) {
            this.deptId = deptId;
            return this;
        }
        public Long getDeptId() {
            return this.deptId;
        }

        public ListOrgTextEmotionResponseBodyResultEmotions setEmotionId(String emotionId) {
            this.emotionId = emotionId;
            return this;
        }
        public String getEmotionId() {
            return this.emotionId;
        }

        public ListOrgTextEmotionResponseBodyResultEmotions setEmotionName(String emotionName) {
            this.emotionName = emotionName;
            return this;
        }
        public String getEmotionName() {
            return this.emotionName;
        }

        public ListOrgTextEmotionResponseBodyResultEmotions setStatus(Integer status) {
            this.status = status;
            return this;
        }
        public Integer getStatus() {
            return this.status;
        }

    }

    public static class ListOrgTextEmotionResponseBodyResult extends TeaModel {
        /**
         * <p>企业文字表情列表</p>
         */
        @NameInMap("emotions")
        public java.util.List<ListOrgTextEmotionResponseBodyResultEmotions> emotions;

        public static ListOrgTextEmotionResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            ListOrgTextEmotionResponseBodyResult self = new ListOrgTextEmotionResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public ListOrgTextEmotionResponseBodyResult setEmotions(java.util.List<ListOrgTextEmotionResponseBodyResultEmotions> emotions) {
            this.emotions = emotions;
            return this;
        }
        public java.util.List<ListOrgTextEmotionResponseBodyResultEmotions> getEmotions() {
            return this.emotions;
        }

    }

}
