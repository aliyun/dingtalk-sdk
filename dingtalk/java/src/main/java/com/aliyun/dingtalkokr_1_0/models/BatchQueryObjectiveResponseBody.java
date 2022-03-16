// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class BatchQueryObjectiveResponseBody extends TeaModel {
    // data
    @NameInMap("data")
    public BatchQueryObjectiveResponseBodyData data;

    // 请求成功的标识。
    @NameInMap("success")
    public Boolean success;

    public static BatchQueryObjectiveResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchQueryObjectiveResponseBody self = new BatchQueryObjectiveResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchQueryObjectiveResponseBody setData(BatchQueryObjectiveResponseBodyData data) {
        this.data = data;
        return this;
    }
    public BatchQueryObjectiveResponseBodyData getData() {
        return this.data;
    }

    public BatchQueryObjectiveResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class BatchQueryObjectiveResponseBodyDataListKrListProgress extends TeaModel {
        // 百分比。
        @NameInMap("percent")
        public Integer percent;

        public static BatchQueryObjectiveResponseBodyDataListKrListProgress build(java.util.Map<String, ?> map) throws Exception {
            BatchQueryObjectiveResponseBodyDataListKrListProgress self = new BatchQueryObjectiveResponseBodyDataListKrListProgress();
            return TeaModel.build(map, self);
        }

        public BatchQueryObjectiveResponseBodyDataListKrListProgress setPercent(Integer percent) {
            this.percent = percent;
            return this;
        }
        public Integer getPercent() {
            return this.percent;
        }

    }

    public static class BatchQueryObjectiveResponseBodyDataListKrList extends TeaModel {
        // KR 内容。
        @NameInMap("content")
        public java.io.InputStream content;

        // KR 的 ID。
        @NameInMap("id")
        public java.io.InputStream id;

        // 所属 Objective ID。
        @NameInMap("objectiveId")
        public java.io.InputStream objectiveId;

        // KR 权限。
        @NameInMap("permission")
        public java.util.List<Float> permission;

        // 所处位置。
        @NameInMap("position")
        public Long position;

        // KR 进度。
        @NameInMap("progress")
        public BatchQueryObjectiveResponseBodyDataListKrListProgress progress;

        // 所占分数。
        @NameInMap("score")
        public Float score;

        // 所占权重。
        @NameInMap("weight")
        public Float weight;

        public static BatchQueryObjectiveResponseBodyDataListKrList build(java.util.Map<String, ?> map) throws Exception {
            BatchQueryObjectiveResponseBodyDataListKrList self = new BatchQueryObjectiveResponseBodyDataListKrList();
            return TeaModel.build(map, self);
        }

        public BatchQueryObjectiveResponseBodyDataListKrList setContent(java.io.InputStream content) {
            this.content = content;
            return this;
        }
        public java.io.InputStream getContent() {
            return this.content;
        }

        public BatchQueryObjectiveResponseBodyDataListKrList setId(java.io.InputStream id) {
            this.id = id;
            return this;
        }
        public java.io.InputStream getId() {
            return this.id;
        }

        public BatchQueryObjectiveResponseBodyDataListKrList setObjectiveId(java.io.InputStream objectiveId) {
            this.objectiveId = objectiveId;
            return this;
        }
        public java.io.InputStream getObjectiveId() {
            return this.objectiveId;
        }

        public BatchQueryObjectiveResponseBodyDataListKrList setPermission(java.util.List<Float> permission) {
            this.permission = permission;
            return this;
        }
        public java.util.List<Float> getPermission() {
            return this.permission;
        }

        public BatchQueryObjectiveResponseBodyDataListKrList setPosition(Long position) {
            this.position = position;
            return this;
        }
        public Long getPosition() {
            return this.position;
        }

        public BatchQueryObjectiveResponseBodyDataListKrList setProgress(BatchQueryObjectiveResponseBodyDataListKrListProgress progress) {
            this.progress = progress;
            return this;
        }
        public BatchQueryObjectiveResponseBodyDataListKrListProgress getProgress() {
            return this.progress;
        }

        public BatchQueryObjectiveResponseBodyDataListKrList setScore(Float score) {
            this.score = score;
            return this;
        }
        public Float getScore() {
            return this.score;
        }

        public BatchQueryObjectiveResponseBodyDataListKrList setWeight(Float weight) {
            this.weight = weight;
            return this;
        }
        public Float getWeight() {
            return this.weight;
        }

    }

    public static class BatchQueryObjectiveResponseBodyDataListOwner extends TeaModel {
        // 所属者头像。 ID
        @NameInMap("avatarMediaId")
        public java.io.InputStream avatarMediaId;

        // 所属者组织 I。D
        @NameInMap("corpId")
        public java.io.InputStream corpId;

        // 所属者 ID。
        @NameInMap("id")
        public java.io.InputStream id;

        // 所属者昵称。
        @NameInMap("nickname")
        public java.io.InputStream nickname;

        // 所属者 userId。
        @NameInMap("staffId")
        public java.io.InputStream staffId;

        public static BatchQueryObjectiveResponseBodyDataListOwner build(java.util.Map<String, ?> map) throws Exception {
            BatchQueryObjectiveResponseBodyDataListOwner self = new BatchQueryObjectiveResponseBodyDataListOwner();
            return TeaModel.build(map, self);
        }

        public BatchQueryObjectiveResponseBodyDataListOwner setAvatarMediaId(java.io.InputStream avatarMediaId) {
            this.avatarMediaId = avatarMediaId;
            return this;
        }
        public java.io.InputStream getAvatarMediaId() {
            return this.avatarMediaId;
        }

        public BatchQueryObjectiveResponseBodyDataListOwner setCorpId(java.io.InputStream corpId) {
            this.corpId = corpId;
            return this;
        }
        public java.io.InputStream getCorpId() {
            return this.corpId;
        }

        public BatchQueryObjectiveResponseBodyDataListOwner setId(java.io.InputStream id) {
            this.id = id;
            return this;
        }
        public java.io.InputStream getId() {
            return this.id;
        }

        public BatchQueryObjectiveResponseBodyDataListOwner setNickname(java.io.InputStream nickname) {
            this.nickname = nickname;
            return this;
        }
        public java.io.InputStream getNickname() {
            return this.nickname;
        }

        public BatchQueryObjectiveResponseBodyDataListOwner setStaffId(java.io.InputStream staffId) {
            this.staffId = staffId;
            return this;
        }
        public java.io.InputStream getStaffId() {
            return this.staffId;
        }

    }

    public static class BatchQueryObjectiveResponseBodyDataListProgress extends TeaModel {
        // 百分比。
        @NameInMap("percent")
        public Integer percent;

        public static BatchQueryObjectiveResponseBodyDataListProgress build(java.util.Map<String, ?> map) throws Exception {
            BatchQueryObjectiveResponseBodyDataListProgress self = new BatchQueryObjectiveResponseBodyDataListProgress();
            return TeaModel.build(map, self);
        }

        public BatchQueryObjectiveResponseBodyDataListProgress setPercent(Integer percent) {
            this.percent = percent;
            return this;
        }
        public Integer getPercent() {
            return this.percent;
        }

    }

    public static class BatchQueryObjectiveResponseBodyDataList extends TeaModel {
        // 被对齐的 Objective。
        @NameInMap("alignFromIds")
        public java.util.List<java.io.InputStream> alignFromIds;

        // 对齐的 Objective。
        @NameInMap("alignToIds")
        public java.util.List<java.io.InputStream> alignToIds;

        // Objective 内容。
        @NameInMap("content")
        public java.io.InputStream content;

        // objective。
        @NameInMap("id")
        public java.io.InputStream id;

        // KR 详情列表。
        @NameInMap("krList")
        public java.util.List<BatchQueryObjectiveResponseBodyDataListKrList> krList;

        // 所属者信息。
        @NameInMap("owner")
        public BatchQueryObjectiveResponseBodyDataListOwner owner;

        // 周期 ID。
        @NameInMap("periodId")
        public java.io.InputStream periodId;

        // 权限值。
        @NameInMap("permission")
        public java.util.List<Float> permission;

        // 所在位置。
        @NameInMap("position")
        public Integer position;

        // 进度值。
        @NameInMap("progress")
        public BatchQueryObjectiveResponseBodyDataListProgress progress;

        // 百分比值。
        @NameInMap("progressPercent")
        public Float progressPercent;

        // 是否已发布。
        @NameInMap("published")
        public Boolean published;

        // 分数值。
        @NameInMap("score")
        public Float score;

        // 当前内容状态。
        @NameInMap("status")
        public Integer status;

        // 用户 ID。
        @NameInMap("userId")
        public java.io.InputStream userId;

        // 权重值。
        @NameInMap("weight")
        public Float weight;

        public static BatchQueryObjectiveResponseBodyDataList build(java.util.Map<String, ?> map) throws Exception {
            BatchQueryObjectiveResponseBodyDataList self = new BatchQueryObjectiveResponseBodyDataList();
            return TeaModel.build(map, self);
        }

        public BatchQueryObjectiveResponseBodyDataList setAlignFromIds(java.util.List<java.io.InputStream> alignFromIds) {
            this.alignFromIds = alignFromIds;
            return this;
        }
        public java.util.List<java.io.InputStream> getAlignFromIds() {
            return this.alignFromIds;
        }

        public BatchQueryObjectiveResponseBodyDataList setAlignToIds(java.util.List<java.io.InputStream> alignToIds) {
            this.alignToIds = alignToIds;
            return this;
        }
        public java.util.List<java.io.InputStream> getAlignToIds() {
            return this.alignToIds;
        }

        public BatchQueryObjectiveResponseBodyDataList setContent(java.io.InputStream content) {
            this.content = content;
            return this;
        }
        public java.io.InputStream getContent() {
            return this.content;
        }

        public BatchQueryObjectiveResponseBodyDataList setId(java.io.InputStream id) {
            this.id = id;
            return this;
        }
        public java.io.InputStream getId() {
            return this.id;
        }

        public BatchQueryObjectiveResponseBodyDataList setKrList(java.util.List<BatchQueryObjectiveResponseBodyDataListKrList> krList) {
            this.krList = krList;
            return this;
        }
        public java.util.List<BatchQueryObjectiveResponseBodyDataListKrList> getKrList() {
            return this.krList;
        }

        public BatchQueryObjectiveResponseBodyDataList setOwner(BatchQueryObjectiveResponseBodyDataListOwner owner) {
            this.owner = owner;
            return this;
        }
        public BatchQueryObjectiveResponseBodyDataListOwner getOwner() {
            return this.owner;
        }

        public BatchQueryObjectiveResponseBodyDataList setPeriodId(java.io.InputStream periodId) {
            this.periodId = periodId;
            return this;
        }
        public java.io.InputStream getPeriodId() {
            return this.periodId;
        }

        public BatchQueryObjectiveResponseBodyDataList setPermission(java.util.List<Float> permission) {
            this.permission = permission;
            return this;
        }
        public java.util.List<Float> getPermission() {
            return this.permission;
        }

        public BatchQueryObjectiveResponseBodyDataList setPosition(Integer position) {
            this.position = position;
            return this;
        }
        public Integer getPosition() {
            return this.position;
        }

        public BatchQueryObjectiveResponseBodyDataList setProgress(BatchQueryObjectiveResponseBodyDataListProgress progress) {
            this.progress = progress;
            return this;
        }
        public BatchQueryObjectiveResponseBodyDataListProgress getProgress() {
            return this.progress;
        }

        public BatchQueryObjectiveResponseBodyDataList setProgressPercent(Float progressPercent) {
            this.progressPercent = progressPercent;
            return this;
        }
        public Float getProgressPercent() {
            return this.progressPercent;
        }

        public BatchQueryObjectiveResponseBodyDataList setPublished(Boolean published) {
            this.published = published;
            return this;
        }
        public Boolean getPublished() {
            return this.published;
        }

        public BatchQueryObjectiveResponseBodyDataList setScore(Float score) {
            this.score = score;
            return this;
        }
        public Float getScore() {
            return this.score;
        }

        public BatchQueryObjectiveResponseBodyDataList setStatus(Integer status) {
            this.status = status;
            return this;
        }
        public Integer getStatus() {
            return this.status;
        }

        public BatchQueryObjectiveResponseBodyDataList setUserId(java.io.InputStream userId) {
            this.userId = userId;
            return this;
        }
        public java.io.InputStream getUserId() {
            return this.userId;
        }

        public BatchQueryObjectiveResponseBodyDataList setWeight(Float weight) {
            this.weight = weight;
            return this;
        }
        public Float getWeight() {
            return this.weight;
        }

    }

    public static class BatchQueryObjectiveResponseBodyData extends TeaModel {
        // OKR 列表详情。
        @NameInMap("list")
        public java.util.List<BatchQueryObjectiveResponseBodyDataList> list;

        // 当前页码。
        @NameInMap("pageNo")
        public Long pageNo;

        // 每一页的个数。
        @NameInMap("pageSize")
        public Long pageSize;

        // 总数。
        @NameInMap("totalCount")
        public Long totalCount;

        public static BatchQueryObjectiveResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            BatchQueryObjectiveResponseBodyData self = new BatchQueryObjectiveResponseBodyData();
            return TeaModel.build(map, self);
        }

        public BatchQueryObjectiveResponseBodyData setList(java.util.List<BatchQueryObjectiveResponseBodyDataList> list) {
            this.list = list;
            return this;
        }
        public java.util.List<BatchQueryObjectiveResponseBodyDataList> getList() {
            return this.list;
        }

        public BatchQueryObjectiveResponseBodyData setPageNo(Long pageNo) {
            this.pageNo = pageNo;
            return this;
        }
        public Long getPageNo() {
            return this.pageNo;
        }

        public BatchQueryObjectiveResponseBodyData setPageSize(Long pageSize) {
            this.pageSize = pageSize;
            return this;
        }
        public Long getPageSize() {
            return this.pageSize;
        }

        public BatchQueryObjectiveResponseBodyData setTotalCount(Long totalCount) {
            this.totalCount = totalCount;
            return this;
        }
        public Long getTotalCount() {
            return this.totalCount;
        }

    }

}
