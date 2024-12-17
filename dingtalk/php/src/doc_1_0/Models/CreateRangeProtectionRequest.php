<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\CreateRangeProtectionRequest\editableSetting;
use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\CreateRangeProtectionRequest\members;
use AlibabaCloud\Tea\Model;

class CreateRangeProtectionRequest extends Model
{
    /**
     * @var editableSetting
     */
    public $editableSetting;

    /**
     * @var members[]
     */
    public $members;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $otherUserPermission;

    /**
     * @description This parameter is required.
     *
     * @example ppgAQuHfOoNVpJiStDwWCEgiEiE
     *
     * @var string
     */
    public $operatorId;
    protected $_name = [
        'editableSetting'     => 'editableSetting',
        'members'             => 'members',
        'otherUserPermission' => 'otherUserPermission',
        'operatorId'          => 'operatorId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->editableSetting) {
            $res['editableSetting'] = null !== $this->editableSetting ? $this->editableSetting->toMap() : null;
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
        if (null !== $this->otherUserPermission) {
            $res['otherUserPermission'] = $this->otherUserPermission;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateRangeProtectionRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['editableSetting'])) {
            $model->editableSetting = editableSetting::fromMap($map['editableSetting']);
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
        if (isset($map['otherUserPermission'])) {
            $model->otherUserPermission = $map['otherUserPermission'];
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }

        return $model;
    }
}
