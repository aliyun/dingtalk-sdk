<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\CreateWorkTimeApproveResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example 636c9634b183ac0040ee85b4
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
     * @example ding123xxx
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
     * @example 636c9634b183ac0040ee85b4
     *
     * @var string
     */
    public $taskId;

    /**
     * @example 100000
     *
     * @var int
     */
    public $time;

    /**
     * @example 2022-07-04T03:29:34.770Z
     *
     * @var string
     */
    public $updatedAt;

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
        'approveOpenId' => 'approveOpenId',
        'createdAt' => 'createdAt',
        'creatorId' => 'creatorId',
        'organizationId' => 'organizationId',
        'status' => 'status',
        'taskId' => 'taskId',
        'time' => 'time',
        'updatedAt' => 'updatedAt',
        'userId' => 'userId',
        'workTimeIds' => 'workTimeIds',
    ];

    public function validate() {}

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
        if (null !== $this->organizationId) {
            $res['organizationId'] = $this->organizationId;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->taskId) {
            $res['taskId'] = $this->taskId;
        }
        if (null !== $this->time) {
            $res['time'] = $this->time;
        }
        if (null !== $this->updatedAt) {
            $res['updatedAt'] = $this->updatedAt;
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
        if (isset($map['organizationId'])) {
            $model->organizationId = $map['organizationId'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['taskId'])) {
            $model->taskId = $map['taskId'];
        }
        if (isset($map['time'])) {
            $model->time = $map['time'];
        }
        if (isset($map['updatedAt'])) {
            $model->updatedAt = $map['updatedAt'];
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
