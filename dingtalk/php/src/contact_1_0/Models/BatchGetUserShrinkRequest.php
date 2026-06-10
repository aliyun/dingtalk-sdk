<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class BatchGetUserShrinkRequest extends Model
{
    /**
     * @var string
     */
    public $permissionCode;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $userIdListShrink;
    protected $_name = [
        'permissionCode' => 'permissionCode',
        'userIdListShrink' => 'userIdList',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->permissionCode) {
            $res['permissionCode'] = $this->permissionCode;
        }
        if (null !== $this->userIdListShrink) {
            $res['userIdList'] = $this->userIdListShrink;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BatchGetUserShrinkRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['permissionCode'])) {
            $model->permissionCode = $map['permissionCode'];
        }
        if (isset($map['userIdList'])) {
            $model->userIdListShrink = $map['userIdList'];
        }

        return $model;
    }
}
