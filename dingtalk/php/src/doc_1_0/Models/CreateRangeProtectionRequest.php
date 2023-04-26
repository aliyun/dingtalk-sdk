<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\CreateRangeProtectionRequest\editableSetting;
use AlibabaCloud\Tea\Model;

class CreateRangeProtectionRequest extends Model
{
    /**
     * @var editableSetting
     */
    public $editableSetting;

    /**
     * @var string
     */
    public $otherUserPermission;

    /**
     * @example ppgAQuHfOoNVpJiStDwWCEgiEiE
     *
     * @var string
     */
    public $operatorId;
    protected $_name = [
        'editableSetting'     => 'editableSetting',
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
        if (isset($map['otherUserPermission'])) {
            $model->otherUserPermission = $map['otherUserPermission'];
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }

        return $model;
    }
}
