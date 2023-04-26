<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetTbUserIdByStaffIdRequest extends Model
{
    /**
     * @example 0175xxxx
     *
     * @var string
     */
    public $optUserId;

    /**
     * @example 0175xxxx
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'optUserId' => 'optUserId',
        'userId'    => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->optUserId) {
            $res['optUserId'] = $this->optUserId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetTbUserIdByStaffIdRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['optUserId'])) {
            $model->optUserId = $map['optUserId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
