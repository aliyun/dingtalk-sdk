<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\RemoveTeamMembersRequest\members;
use AlibabaCloud\Tea\Model;

class RemoveTeamMembersRequest extends Model
{
    /**
     * @description 待移除的成员列表。
     *
     * @var members[]
     */
    public $members;

    /**
     * @description 是否通知被移除的成员，默认否。
     *
     * @var bool
     */
    public $notify;

    /**
     * @description 操作人unionId。
     *
     * @var string
     */
    public $operatorId;
    protected $_name = [
        'members'    => 'members',
        'notify'     => 'notify',
        'operatorId' => 'operatorId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->members) {
            $res['members'] = [];
            if (null !== $this->members && \is_array($this->members)) {
                $n = 0;
                foreach ($this->members as $item) {
                    $res['members'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->notify) {
            $res['notify'] = $this->notify;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RemoveTeamMembersRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['members'])) {
            if (!empty($map['members'])) {
                $model->members = [];
                $n              = 0;
                foreach ($map['members'] as $item) {
                    $model->members[$n++] = null !== $item ? members::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['notify'])) {
            $model->notify = $map['notify'];
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }

        return $model;
    }
}
