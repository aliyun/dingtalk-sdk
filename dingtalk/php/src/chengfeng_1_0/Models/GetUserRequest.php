<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetUserRequest extends Model
{
    /**
     * @description OKR系统内部用户id
     *
     * @var string
     */
    public $okrUserId;

    /**
     * @description 钉钉UserId
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'okrUserId' => 'okrUserId',
        'userId'    => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->okrUserId) {
            $res['okrUserId'] = $this->okrUserId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetUserRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['okrUserId'])) {
            $model->okrUserId = $map['okrUserId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
