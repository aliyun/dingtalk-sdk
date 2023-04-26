<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\GetTodoTaskDetailResponseBody\detailUrl;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\GetTodoTaskDetailResponseBody\executorStatus;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\GetTodoTaskDetailResponseBody\orgInfo;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\GetTodoTaskDetailResponseBody\todoCardView;
use AlibabaCloud\Tea\Model;

class GetTodoTaskDetailResponseBody extends Model
{
    /**
     * @var string
     */
    public $bizTag;

    /**
     * @var string
     */
    public $category;

    /**
     * @var int
     */
    public $createdTime;

    /**
     * @var string
     */
    public $creatorId;

    /**
     * @var string
     */
    public $description;

    /**
     * @var detailUrl
     */
    public $detailUrl;

    /**
     * @var bool
     */
    public $done;

    /**
     * @var int
     */
    public $dueTime;

    /**
     * @var string[]
     */
    public $executorIds;

    /**
     * @var executorStatus[]
     */
    public $executorStatus;

    /**
     * @var int
     */
    public $finishTime;

    /**
     * @var string
     */
    public $id;

    /**
     * @var bool
     */
    public $isOnlyShowExecutor;

    /**
     * @var int
     */
    public $modifiedTime;

    /**
     * @var string
     */
    public $modifierId;

    /**
     * @var orgInfo
     */
    public $orgInfo;

    /**
     * @var string[]
     */
    public $participantIds;

    /**
     * @var int
     */
    public $priority;

    /**
     * @var string
     */
    public $requestId;

    /**
     * @var string
     */
    public $source;

    /**
     * @var string
     */
    public $sourceId;

    /**
     * @var int
     */
    public $startTime;

    /**
     * @var string
     */
    public $subject;

    /**
     * @var string
     */
    public $tenantId;

    /**
     * @var string
     */
    public $tenantType;

    /**
     * @var todoCardView
     */
    public $todoCardView;
    protected $_name = [
        'bizTag'             => 'bizTag',
        'category'           => 'category',
        'createdTime'        => 'createdTime',
        'creatorId'          => 'creatorId',
        'description'        => 'description',
        'detailUrl'          => 'detailUrl',
        'done'               => 'done',
        'dueTime'            => 'dueTime',
        'executorIds'        => 'executorIds',
        'executorStatus'     => 'executorStatus',
        'finishTime'         => 'finishTime',
        'id'                 => 'id',
        'isOnlyShowExecutor' => 'isOnlyShowExecutor',
        'modifiedTime'       => 'modifiedTime',
        'modifierId'         => 'modifierId',
        'orgInfo'            => 'orgInfo',
        'participantIds'     => 'participantIds',
        'priority'           => 'priority',
        'requestId'          => 'requestId',
        'source'             => 'source',
        'sourceId'           => 'sourceId',
        'startTime'          => 'startTime',
        'subject'            => 'subject',
        'tenantId'           => 'tenantId',
        'tenantType'         => 'tenantType',
        'todoCardView'       => 'todoCardView',
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
        if (null !== $this->category) {
            $res['category'] = $this->category;
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
        if (null !== $this->executorStatus) {
            $res['executorStatus'] = [];
            if (null !== $this->executorStatus && \is_array($this->executorStatus)) {
                $n = 0;
                foreach ($this->executorStatus as $item) {
                    $res['executorStatus'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
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
        if (null !== $this->orgInfo) {
            $res['orgInfo'] = null !== $this->orgInfo ? $this->orgInfo->toMap() : null;
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
        if (null !== $this->todoCardView) {
            $res['todoCardView'] = null !== $this->todoCardView ? $this->todoCardView->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetTodoTaskDetailResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizTag'])) {
            $model->bizTag = $map['bizTag'];
        }
        if (isset($map['category'])) {
            $model->category = $map['category'];
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
        if (isset($map['executorStatus'])) {
            if (!empty($map['executorStatus'])) {
                $model->executorStatus = [];
                $n                     = 0;
                foreach ($map['executorStatus'] as $item) {
                    $model->executorStatus[$n++] = null !== $item ? executorStatus::fromMap($item) : $item;
                }
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
        if (isset($map['orgInfo'])) {
            $model->orgInfo = orgInfo::fromMap($map['orgInfo']);
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
        if (isset($map['todoCardView'])) {
            $model->todoCardView = todoCardView::fromMap($map['todoCardView']);
        }

        return $model;
    }
}
