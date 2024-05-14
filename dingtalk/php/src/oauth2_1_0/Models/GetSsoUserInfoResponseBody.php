<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Voauth2_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetSsoUserInfoResponseBody extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $avatar;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $corpId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $corpName;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $email;

    /**
     * @description This parameter is required.
     *
     * @var bool
     */
    public $isAdmin;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $userId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $userName;
    protected $_name = [
        'avatar'   => 'avatar',
        'corpId'   => 'corpId',
        'corpName' => 'corpName',
        'email'    => 'email',
        'isAdmin'  => 'isAdmin',
        'userId'   => 'userId',
        'userName' => 'userName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->avatar) {
            $res['avatar'] = $this->avatar;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->corpName) {
            $res['corpName'] = $this->corpName;
        }
        if (null !== $this->email) {
            $res['email'] = $this->email;
        }
        if (null !== $this->isAdmin) {
            $res['isAdmin'] = $this->isAdmin;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->userName) {
            $res['userName'] = $this->userName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetSsoUserInfoResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['avatar'])) {
            $model->avatar = $map['avatar'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['corpName'])) {
            $model->corpName = $map['corpName'];
        }
        if (isset($map['email'])) {
            $model->email = $map['email'];
        }
        if (isset($map['isAdmin'])) {
            $model->isAdmin = $map['isAdmin'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['userName'])) {
            $model->userName = $map['userName'];
        }

        return $model;
    }
}
