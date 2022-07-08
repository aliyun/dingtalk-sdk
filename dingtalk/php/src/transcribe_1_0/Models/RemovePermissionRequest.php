<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtranscribe_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vtranscribe_1_0\Models\RemovePermissionRequest\members;
use AlibabaCloud\Tea\Model;

class RemovePermissionRequest extends Model
{
    /**
     * @var int
     */
    public $bizType;

    /**
     * @var members[]
     */
    public $members;

    /**
     * @description 任务的创建者uid
     *
     * @var int
     */
    public $taskCreator;

    /**
     * @description 闪记任务的闪记ID
     *
     * @var int
     */
    public $taskId;
    protected $_name = [
        'bizType'     => 'bizType',
        'members'     => 'members',
        'taskCreator' => 'taskCreator',
        'taskId'      => 'taskId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizType) {
            $res['bizType'] = $this->bizType;
        }
        if (null !== $this->members) {
            $res['members'] = [];
            if (null !== $this->members && \is_array($this->members)) {
                $n = 0;
                foreach ($this->members as $item) {
                    $res['members'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->taskCreator) {
            $res['taskCreator'] = $this->taskCreator;
        }
        if (null !== $this->taskId) {
            $res['taskId'] = $this->taskId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RemovePermissionRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizType'])) {
            $model->bizType = $map['bizType'];
        }
        if (isset($map['members'])) {
            if (!empty($map['members'])) {
                $model->members = [];
                $n              = 0;
                foreach ($map['members'] as $item) {
                    $model->members[$n++] = null !== $item ? members::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['taskCreator'])) {
            $model->taskCreator = $map['taskCreator'];
        }
        if (isset($map['taskId'])) {
            $model->taskId = $map['taskId'];
        }

        return $model;
    }
}
