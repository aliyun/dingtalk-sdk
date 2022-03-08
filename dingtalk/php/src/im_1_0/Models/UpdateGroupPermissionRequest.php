<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateGroupPermissionRequest extends Model
{
    /**
     * @description 开放群ID
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @description 群权限项
     *
     * @var string
     */
    public $permissionGroup;

    /**
     * @description 状态,0-关闭，1-开启
     *
     * @var string
     */
    public $status;
    protected $_name = [
        'openConversationId' => 'openConversationId',
        'permissionGroup'    => 'permissionGroup',
        'status'             => 'status',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->permissionGroup) {
            $res['permissionGroup'] = $this->permissionGroup;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateGroupPermissionRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['permissionGroup'])) {
            $model->permissionGroup = $map['permissionGroup'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
