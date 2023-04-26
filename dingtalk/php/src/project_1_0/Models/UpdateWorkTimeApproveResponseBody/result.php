<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateWorkTimeApproveResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example 6446626a9fb5a70c05fc3fc3
     *
     * @var string
     */
    public $approveOpenId;

    /**
     * @example 2022-07-04T03:29:34.770Z
     *
     * @var string
     */
    public $createdAt;

    /**
     * @example 6446626a9fb5a70c05fc3fc3
     *
     * @var string
     */
    public $creatorId;

    /**
     * @example 2023-04-04T00:00:00.000Z
     *
     * @var string
     */
    public $finishTime;

    /**
     * @example 12345
     *
     * @var string
     */
    public $instanceId;

    /**
     * @example dingxxxx
     *
     * @var string
     */
    public $organizationId;

    /**
     * @example NEW
     *
     * @var string
     */
    public $status;

    /**
     * @example 2023-04-04T00:00:00.000Z
     *
     * @var string
     */
    public $submitTime;

    /**
     * @example 6446626a9fb5a70c05fc3fc3
     *
     * @var string
     */
    public $taskId;

    /**
     * @example 10000
     *
     * @var int
     */
    public $time;

    /**
     * @example xxx用工申请
     *
     * @var string
     */
    public $title;

    /**
     * @example 2022-07-04T03:29:34.770Z
     *
     * @var string
     */
    public $updatedAt;

    /**
     * @example https://xxxbpms.xxx/xxxx
     *
     * @var string
     */
    public $url;

    /**
     * @example 6446626a9fb5a70c05fc3fc3
     *
     * @var string
     */
    public $userId;

    /**
     * @var string[]
     */
    public $workTimeIds;
    protected $_name = [
        'approveOpenId'  => 'approveOpenId',
        'createdAt'      => 'createdAt',
        'creatorId'      => 'creatorId',
        'finishTime'     => 'finishTime',
        'instanceId'     => 'instanceId',
        'organizationId' => 'organizationId',
        'status'         => 'status',
        'submitTime'     => 'submitTime',
        'taskId'         => 'taskId',
        'time'           => 'time',
        'title'          => 'title',
        'updatedAt'      => 'updatedAt',
        'url'            => 'url',
        'userId'         => 'userId',
        'workTimeIds'    => 'workTimeIds',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->approveOpenId) {
            $res['approveOpenId'] = $this->approveOpenId;
        }
        if (null !== $this->createdAt) {
            $res['createdAt'] = $this->createdAt;
        }
        if (null !== $this->creatorId) {
            $res['creatorId'] = $this->creatorId;
        }
        if (null !== $this->finishTime) {
            $res['finishTime'] = $this->finishTime;
        }
        if (null !== $this->instanceId) {
            $res['instanceId'] = $this->instanceId;
        }
        if (null !== $this->organizationId) {
            $res['organizationId'] = $this->organizationId;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->submitTime) {
            $res['submitTime'] = $this->submitTime;
        }
        if (null !== $this->taskId) {
            $res['taskId'] = $this->taskId;
        }
        if (null !== $this->time) {
            $res['time'] = $this->time;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->updatedAt) {
            $res['updatedAt'] = $this->updatedAt;
        }
        if (null !== $this->url) {
            $res['url'] = $this->url;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->workTimeIds) {
            $res['workTimeIds'] = $this->workTimeIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['approveOpenId'])) {
            $model->approveOpenId = $map['approveOpenId'];
        }
        if (isset($map['createdAt'])) {
            $model->createdAt = $map['createdAt'];
        }
        if (isset($map['creatorId'])) {
            $model->creatorId = $map['creatorId'];
        }
        if (isset($map['finishTime'])) {
            $model->finishTime = $map['finishTime'];
        }
        if (isset($map['instanceId'])) {
            $model->instanceId = $map['instanceId'];
        }
        if (isset($map['organizationId'])) {
            $model->organizationId = $map['organizationId'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['submitTime'])) {
            $model->submitTime = $map['submitTime'];
        }
        if (isset($map['taskId'])) {
            $model->taskId = $map['taskId'];
        }
        if (isset($map['time'])) {
            $model->time = $map['time'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['updatedAt'])) {
            $model->updatedAt = $map['updatedAt'];
        }
        if (isset($map['url'])) {
            $model->url = $map['url'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['workTimeIds'])) {
            if (!empty($map['workTimeIds'])) {
                $model->workTimeIds = $map['workTimeIds'];
            }
        }

        return $model;
    }
}
