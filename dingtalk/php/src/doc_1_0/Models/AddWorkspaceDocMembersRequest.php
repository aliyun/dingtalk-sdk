<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\AddWorkspaceDocMembersRequest\members;
use AlibabaCloud\Tea\Model;

class AddWorkspaceDocMembersRequest extends Model
{
    /**
     * @description 发起操作者unionId
     *
     * @var string
     */
    public $operatorId;

    /**
     * @description 被操作用户组
     *
     * @var members[]
     */
    public $members;
    protected $_name = [
        'operatorId' => 'operatorId',
        'members'    => 'members',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
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

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddWorkspaceDocMembersRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
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

        return $model;
    }
}
