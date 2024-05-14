<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\CreateTodoTaskRequest\actionList;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\CreateTodoTaskRequest\contentFieldList;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\CreateTodoTaskRequest\detailUrl;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\CreateTodoTaskRequest\notifyConfigs;
use AlibabaCloud\Tea\Model;

class CreateTodoTaskRequest extends Model
{
    /**
     * @var actionList[]
     */
    public $actionList;

    /**
     * @var string
     */
    public $bizCategoryId;

    /**
     * @var contentFieldList[]
     */
    public $contentFieldList;

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
     * @var int
     */
    public $dueTime;

    /**
     * @var string[]
     */
    public $executorIds;

    /**
     * @var bool
     */
    public $isOnlyShowExecutor;

    /**
     * @var notifyConfigs
     */
    public $notifyConfigs;

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
    public $sourceId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $subject;

    /**
     * @var string
     */
    public $operatorId;
    protected $_name = [
        'actionList'         => 'actionList',
        'bizCategoryId'      => 'bizCategoryId',
        'contentFieldList'   => 'contentFieldList',
        'creatorId'          => 'creatorId',
        'description'        => 'description',
        'detailUrl'          => 'detailUrl',
        'dueTime'            => 'dueTime',
        'executorIds'        => 'executorIds',
        'isOnlyShowExecutor' => 'isOnlyShowExecutor',
        'notifyConfigs'      => 'notifyConfigs',
        'participantIds'     => 'participantIds',
        'priority'           => 'priority',
        'sourceId'           => 'sourceId',
        'subject'            => 'subject',
        'operatorId'         => 'operatorId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->actionList) {
            $res['actionList'] = [];
            if (null !== $this->actionList && \is_array($this->actionList)) {
                $n = 0;
                foreach ($this->actionList as $item) {
                    $res['actionList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->bizCategoryId) {
            $res['bizCategoryId'] = $this->bizCategoryId;
        }
        if (null !== $this->contentFieldList) {
            $res['contentFieldList'] = [];
            if (null !== $this->contentFieldList && \is_array($this->contentFieldList)) {
                $n = 0;
                foreach ($this->contentFieldList as $item) {
                    $res['contentFieldList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
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
        if (null !== $this->dueTime) {
            $res['dueTime'] = $this->dueTime;
        }
        if (null !== $this->executorIds) {
            $res['executorIds'] = $this->executorIds;
        }
        if (null !== $this->isOnlyShowExecutor) {
            $res['isOnlyShowExecutor'] = $this->isOnlyShowExecutor;
        }
        if (null !== $this->notifyConfigs) {
            $res['notifyConfigs'] = null !== $this->notifyConfigs ? $this->notifyConfigs->toMap() : null;
        }
        if (null !== $this->participantIds) {
            $res['participantIds'] = $this->participantIds;
        }
        if (null !== $this->priority) {
            $res['priority'] = $this->priority;
        }
        if (null !== $this->sourceId) {
            $res['sourceId'] = $this->sourceId;
        }
        if (null !== $this->subject) {
            $res['subject'] = $this->subject;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateTodoTaskRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['actionList'])) {
            if (!empty($map['actionList'])) {
                $model->actionList = [];
                $n                 = 0;
                foreach ($map['actionList'] as $item) {
                    $model->actionList[$n++] = null !== $item ? actionList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['bizCategoryId'])) {
            $model->bizCategoryId = $map['bizCategoryId'];
        }
        if (isset($map['contentFieldList'])) {
            if (!empty($map['contentFieldList'])) {
                $model->contentFieldList = [];
                $n                       = 0;
                foreach ($map['contentFieldList'] as $item) {
                    $model->contentFieldList[$n++] = null !== $item ? contentFieldList::fromMap($item) : $item;
                }
            }
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
        if (isset($map['dueTime'])) {
            $model->dueTime = $map['dueTime'];
        }
        if (isset($map['executorIds'])) {
            if (!empty($map['executorIds'])) {
                $model->executorIds = $map['executorIds'];
            }
        }
        if (isset($map['isOnlyShowExecutor'])) {
            $model->isOnlyShowExecutor = $map['isOnlyShowExecutor'];
        }
        if (isset($map['notifyConfigs'])) {
            $model->notifyConfigs = notifyConfigs::fromMap($map['notifyConfigs']);
        }
        if (isset($map['participantIds'])) {
            if (!empty($map['participantIds'])) {
                $model->participantIds = $map['participantIds'];
            }
        }
        if (isset($map['priority'])) {
            $model->priority = $map['priority'];
        }
        if (isset($map['sourceId'])) {
            $model->sourceId = $map['sourceId'];
        }
        if (isset($map['subject'])) {
            $model->subject = $map['subject'];
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }

        return $model;
    }
}
