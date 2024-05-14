<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetFollowerAuthInfoRequest extends Model
{
    /**
     * @example ding1234
     *
     * @var string
     */
    public $accountId;

    /**
     * @description This parameter is required.
     *
     * @example Rp3Rqcts7BE08y49Jr6iu6xW4iQ
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
