<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class BatchGetUserRequest extends Model
{
    /**
     * @var string
     */
    public $permissionCode;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $userIdList;
    protected $_name = [
        'permissionCode' => 'permissionCode',
        'userIdList' => 'userIdList',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->permissionCode) {
            $res['permissionCode'] = $this->permissionCode;
        }
        if (null !== $this->userIdList) {
            $res['userIdList'] = $this->userIdList;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BatchGetUserRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['permissionCode'])) {
            $model->permissionCode = $map['permissionCode'];
        }
        if (isset($map['userIdList'])) {
            if (!empty($map['userIdList'])) {
                $model->userIdList = $map['userIdList'];
            }
        }

        return $model;
    }
}
