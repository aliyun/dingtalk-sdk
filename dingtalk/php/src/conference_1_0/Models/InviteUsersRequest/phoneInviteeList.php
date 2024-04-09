<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\InviteUsersRequest;

use AlibabaCloud\Tea\Model;

class phoneInviteeList extends Model
{
    /**
     * @example 测试电话用户
     *
     * @var string
     */
    public $nick;

    /**
     * @example 1xxxxxxxxxx9
     *
     * @var string
     */
    public $phoneNumber;
    protected $_name = [
        'nick'        => 'nick',
        'phoneNumber' => 'phoneNumber',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->nick) {
            $res['nick'] = $this->nick;
        }
        if (null !== $this->phoneNumber) {
            $res['phoneNumber'] = $this->phoneNumber;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return phoneInviteeList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['nick'])) {
            $model->nick = $map['nick'];
        }
        if (isset($map['phoneNumber'])) {
            $model->phoneNumber = $map['phoneNumber'];
        }

        return $model;
    }
}
