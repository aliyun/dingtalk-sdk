<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetFollowerAuthInfoRequest extends Model
{
    /**
     * @description 服务窗帐号ID，用于非服务窗自建应用场景下指定服务窗帐号。
     *
     * @var string
     */
    public $accountId;

    /**
     * @description 关注用户的userId
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'accountId' => 'accountId',
        'userId'    => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->accountId) {
            $res['accountId'] = $this->accountId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetFollowerAuthInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['accountId'])) {
            $model->accountId = $map['accountId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
