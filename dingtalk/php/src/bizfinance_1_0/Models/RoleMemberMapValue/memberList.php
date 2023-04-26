<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\RoleMemberMapValue;

use AlibabaCloud\Tea\Model;

class memberList extends Model
{
    /**
     * @example abc
     *
     * @var string
     */
    public $userId;

    /**
     * @example 小明
     *
     * @var string
     */
    public $nick;

    /**
     * @example https://xxxxxxx
     *
     * @var string
     */
    public $avatarUrl;
    protected $_name = [
        'userId'    => 'userId',
        'nick'      => 'nick',
        'avatarUrl' => 'avatarUrl',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->nick) {
            $res['nick'] = $this->nick;
        }
        if (null !== $this->avatarUrl) {
            $res['avatarUrl'] = $this->avatarUrl;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return memberList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['nick'])) {
            $model->nick = $map['nick'];
        }
        if (isset($map['avatarUrl'])) {
            $model->avatarUrl = $map['avatarUrl'];
        }

        return $model;
    }
}
