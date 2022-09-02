<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class IsFriendRequest extends Model
{
    /**
     * @description 手机号码
     *
     * @var string
     */
    public $mobileNo;

    /**
     * @description 工号
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'mobileNo' => 'mobileNo',
        'userId'   => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->mobileNo) {
            $res['mobileNo'] = $this->mobileNo;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return IsFriendRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['mobileNo'])) {
            $model->mobileNo = $map['mobileNo'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
