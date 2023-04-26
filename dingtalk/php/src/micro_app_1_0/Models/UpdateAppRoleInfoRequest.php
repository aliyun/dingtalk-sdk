<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateAppRoleInfoRequest extends Model
{
    /**
     * @var bool
     */
    public $canManageRole;

    /**
     * @var string
     */
    public $newRoleName;

    /**
     * @var string
     */
    public $opUserId;
    protected $_name = [
        'canManageRole' => 'canManageRole',
        'newRoleName'   => 'newRoleName',
        'opUserId'      => 'opUserId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->canManageRole) {
            $res['canManageRole'] = $this->canManageRole;
        }
        if (null !== $this->newRoleName) {
            $res['newRoleName'] = $this->newRoleName;
        }
        if (null !== $this->opUserId) {
            $res['opUserId'] = $this->opUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateAppRoleInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['canManageRole'])) {
            $model->canManageRole = $map['canManageRole'];
        }
        if (isset($map['newRoleName'])) {
            $model->newRoleName = $map['newRoleName'];
        }
        if (isset($map['opUserId'])) {
            $model->opUserId = $map['opUserId'];
        }

        return $model;
    }
}
