<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\InviteUsersRequest;

use AlibabaCloud\Tea\Model;

class phoneInviteeList extends Model
{
    /**
     * @example false
     *
     * @var bool
     */
    public $inviteClient;

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

    /**
     * @example 86
     *
     * @var string
     */
    public $statusCode;
    protected $_name = [
        'inviteClient' => 'inviteClient',
        'nick'         => 'nick',
        'phoneNumber'  => 'phoneNumber',
        'statusCode'   => 'statusCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->inviteClient) {
            $res['inviteClient'] = $this->inviteClient;
        }
        if (null !== $this->nick) {
            $res['nick'] = $this->nick;
        }
        if (null !== $this->phoneNumber) {
            $res['phoneNumber'] = $this->phoneNumber;
        }
        if (null !== $this->statusCode) {
            $res['statusCode'] = $this->statusCode;
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
        if (isset($map['inviteClient'])) {
            $model->inviteClient = $map['inviteClient'];
        }
        if (isset($map['nick'])) {
            $model->nick = $map['nick'];
        }
        if (isset($map['phoneNumber'])) {
            $model->phoneNumber = $map['phoneNumber'];
        }
        if (isset($map['statusCode'])) {
            $model->statusCode = $map['statusCode'];
        }

        return $model;
    }
}
