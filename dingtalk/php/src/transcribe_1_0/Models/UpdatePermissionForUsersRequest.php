<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtranscribe_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vtranscribe_1_0\Models\UpdatePermissionForUsersRequest\members;
use AlibabaCloud\Tea\Model;

class UpdatePermissionForUsersRequest extends Model
{
    /**
     * @description 闪记任务的类型。枚举值，从任务详情中获取。
     *
     * @var int
     */
    public $bizType;

    /**
     * @description 被授权的用户信息列表
     *
     * @var members[]
     */
    public $members;

    /**
     * @description 要操作的闪记任务的创建者userId。
     *
     * @var int
     */
    public $taskCreator;

    /**
     * @description 闪记任务的特定标识。是一个不定长的字符串。
     *
     * @var string
     */
    public $uuid;

    /**
     * @var int
     */
    public $operatorUid;
    protected $_name = [
        'bizType'     => 'bizType',
        'members'     => 'members',
        'taskCreator' => 'taskCreator',
        'uuid'        => 'uuid',
        'operatorUid' => 'operatorUid',
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
        if (null !== $this->uuid) {
            $res['uuid'] = $this->uuid;
        }
        if (null !== $this->operatorUid) {
            $res['operatorUid'] = $this->operatorUid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdatePermissionForUsersRequest
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
        if (isset($map['uuid'])) {
            $model->uuid = $map['uuid'];
        }
        if (isset($map['operatorUid'])) {
            $model->operatorUid = $map['operatorUid'];
        }

        return $model;
    }
}
