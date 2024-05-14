<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\InviteUsersRequest;

use AlibabaCloud\Tea\Model;

class inviteeList extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 测试用户
     *
     * @var string
     */
    public $nick;

    /**
     * @example qzR1iSMDvzR9kXXXXXXXx
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'nick'    => 'nick',
        'unionId' => 'unionId',
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
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return inviteeList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['nick'])) {
            $model->nick = $map['nick'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
