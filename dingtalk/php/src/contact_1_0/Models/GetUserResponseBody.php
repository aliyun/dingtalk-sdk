<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetUserResponseBody extends Model
{
    /**
     * @description 昵称
     *
     * @var string
     */
    public $nick;

    /**
     * @description 头像url
     *
     * @var string
     */
    public $avatarUrl;

    /**
     * @description 手机号
     *
     * @var string
     */
    public $mobile;

    /**
     * @description openId
     *
     * @var string
     */
    public $openId;

    /**
     * @description unionId
     *
     * @var string
     */
    public $unionId;

    /**
     * @description 个人邮箱
     *
     * @var string
     */
    public $email;
    protected $_name = [
        'nick'      => 'nick',
        'avatarUrl' => 'avatarUrl',
        'mobile'    => 'mobile',
        'openId'    => 'openId',
        'unionId'   => 'unionId',
        'email'     => 'email',
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
        if (null !== $this->avatarUrl) {
            $res['avatarUrl'] = $this->avatarUrl;
        }
        if (null !== $this->mobile) {
            $res['mobile'] = $this->mobile;
        }
        if (null !== $this->openId) {
            $res['openId'] = $this->openId;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }
        if (null !== $this->email) {
            $res['email'] = $this->email;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetUserResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['nick'])) {
            $model->nick = $map['nick'];
        }
        if (isset($map['avatarUrl'])) {
            $model->avatarUrl = $map['avatarUrl'];
        }
        if (isset($map['mobile'])) {
            $model->mobile = $map['mobile'];
        }
        if (isset($map['openId'])) {
            $model->openId = $map['openId'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }
        if (isset($map['email'])) {
            $model->email = $map['email'];
        }

        return $model;
    }
}
