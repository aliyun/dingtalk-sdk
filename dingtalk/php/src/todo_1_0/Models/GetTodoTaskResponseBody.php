<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\GetTodoTaskResponseBody\detailUrl;
use AlibabaCloud\Tea\Model;

class GetTodoTaskResponseBody extends Model
{
    /**
     * @description 接入业务应用标识
     *
     * @var string
     */
    public $bizTag;

    /**
     * @description 待办卡片类型id
     *
     * @var string
     */
    public $cardTypeId;

    /**
     * @description 创建时间
     *
     * @var int
     */
    public $createdTime;

    /**
     * @description 创建者id（用户的unionId）
     *
     * @var string
     */
    public $creatorId;

    /**
     * @description 描述
     *
     * @var string
     */
    public $description;

    /**
     * @description 自定义详情页跳转配置
     *
     * @var detailUrl
     */
    public $detailUrl;

    /**
     * @description 完成状态
     *
     * @var bool
     */
    public $done;

    /**
     * @description 截止时间
     *
     * @var int
     */
    public $dueTime;

    /**
     * @description 执行者列表（用户的unionId）
     *
     * @var string[]
     */
    public $executorIds;

    /**
     * @description 完成时间
     *
     * @var int
     */
    public $finishTime;

    /**
     * @description id
     *
     * @var string
     */
    public $id;

    /**
     * @description 待办是否仅展示在执行人的待办列表中
     *
     * @var bool
     */
    public $isOnlyShowExecutor;

    /**
     * @description 更新时间
     *
     * @var int
     */
    public $modifiedTime;

    /**
     * @description 更新者id（用户的unionId）
     *
     * @var string
     */
    public $modifierId;

    /**
     * @description 参与者列表（用户的unionId）
     *
     * @var string[]
     */
    public $participantIds;

    /**
     * @description 优先级, 较低:10, 普通:20, 紧急:30, 非常紧急:40
     *
     * @var int
     */
    public $priority;

    /**
     * @description requestId
     *
     * @var string
     */
    public $requestId;

    /**
     * @description 业务来源
     *
     * @var string
     */
    public $source;

    /**
     * @description 业务来源id
     *
     * @var string
     */
    public $sourceId;

    /**
     * @description 开始时间
     *
     * @var int
     */
    public $startTime;

    /**
     * @description 标题
     *
     * @var string
     */
    public $subject;

    /**
     * @description 租户id(unionId/orgId/groupId)
     *
     * @var string
     */
    public $tenantId;

    /**
     * @description 租户类型（user/org/group）
     *
     * @var string
     */
    public $tenantType;
    protected $_name = [
        'bizTag'             => 'bizTag',
        'cardTypeId'         => 'cardTypeId',
        'createdTime'        => 'createdTime',
        'creatorId'          => 'creatorId',
        'description'        => 'description',
        'detailUrl'          => 'detailUrl',
        'done'               => 'done',
        'dueTime'            => 'dueTime',
        'executorIds'        => 'executorIds',
        'finishTime'         => 'finishTime',
        'id'                 => 'id',
        'isOnlyShowExecutor' => 'isOnlyShowExecutor',
        'modifiedTime'       => 'modifiedTime',
        'modifierId'         => 'modifierId',
        'participantIds'     => 'participantIds',
        'priority'           => 'priority',
        'requestId'          => 'requestId',
        'source'             => 'source',
        'sourceId'           => 'sourceId',
        'startTime'          => 'startTime',
        'subject'            => 'subject',
        'tenantId'           => 'tenantId',
        'tenantType'         => 'tenantType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizTag) {
            $res['bizTag'] = $this->bizTag;
        }
        if (null !== $this->cardTypeId) {
            $res['cardTypeId'] = $this->cardTypeId;
        }
        if (null !== $this->createdTime) {
            $res['createdTime'] = $this->createdTime;
        }
        if (null !== $this->creatorId) {
            $res['creatorId'] = $this->creatorId;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->detailUrl) {
            $res['detailUrl'] = null !== $this->detailUrl ? $this->detailUrl->toMap() : null;
        }
        if (null !== $this->done) {
            $res['done'] = $this->done;
        }
        if (null !== $this->dueTime) {
            $res['dueTime'] = $this->dueTime;
        }
        if (null !== $this->executorIds) {
            $res['executorIds'] = $this->executorIds;
        }
        if (null !== $this->finishTime) {
            $res['finishTime'] = $this->finishTime;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->isOnlyShowExecutor) {
            $res['isOnlyShowExecutor'] = $this->isOnlyShowExecutor;
        }
        if (null !== $this->modifiedTime) {
            $res['modifiedTime'] = $this->modifiedTime;
        }
        if (null !== $this->modifierId) {
            $res['modifierId'] = $this->modifierId;
        }
        if (null !== $this->participantIds) {
            $res['participantIds'] = $this->participantIds;
        }
        if (null !== $this->priority) {
            $res['priority'] = $this->priority;
        }
        if (null !== $this->requestId) {
            $res['requestId'] = $this->requestId;
        }
        if (null !== $this->source) {
            $res['source'] = $this->source;
        }
        if (null !== $this->sourceId) {
            $res['sourceId'] = $this->sourceId;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->subject) {
            $res['subject'] = $this->subject;
        }
        if (null !== $this->tenantId) {
            $res['tenantId'] = $this->tenantId;
        }
        if (null !== $this->tenantType) {
            $res['tenantType'] = $this->tenantType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetTodoTaskResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizTag'])) {
            $model->bizTag = $map['bizTag'];
        }
        if (isset($map['cardTypeId'])) {
            $model->cardTypeId = $map['cardTypeId'];
        }
        if (isset($map['createdTime'])) {
            $model->createdTime = $map['createdTime'];
        }
        if (isset($map['creatorId'])) {
            $model->creatorId = $map['creatorId'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['detailUrl'])) {
            $model->detailUrl = detailUrl::fromMap($map['detailUrl']);
        }
        if (isset($map['done'])) {
            $model->done = $map['done'];
        }
        if (isset($map['dueTime'])) {
            $model->dueTime = $map['dueTime'];
        }
        if (isset($map['executorIds'])) {
            if (!empty($map['executorIds'])) {
                $model->executorIds = $map['executorIds'];
            }
        }
        if (isset($map['finishTime'])) {
            $model->finishTime = $map['finishTime'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['isOnlyShowExecutor'])) {
            $model->isOnlyShowExecutor = $map['isOnlyShowExecutor'];
        }
        if (isset($map['modifiedTime'])) {
            $model->modifiedTime = $map['modifiedTime'];
        }
        if (isset($map['modifierId'])) {
            $model->modifierId = $map['modifierId'];
        }
        if (isset($map['participantIds'])) {
            if (!empty($map['participantIds'])) {
                $model->participantIds = $map['participantIds'];
            }
        }
        if (isset($map['priority'])) {
            $model->priority = $map['priority'];
        }
        if (isset($map['requestId'])) {
            $model->requestId = $map['requestId'];
        }
        if (isset($map['source'])) {
            $model->source = $map['source'];
        }
        if (isset($map['sourceId'])) {
            $model->sourceId = $map['sourceId'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['subject'])) {
            $model->subject = $map['subject'];
        }
        if (isset($map['tenantId'])) {
            $model->tenantId = $map['tenantId'];
        }
        if (isset($map['tenantType'])) {
            $model->tenantType = $map['tenantType'];
        }

        return $model;
    }
}
