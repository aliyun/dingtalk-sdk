<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Voauth2_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetSsoUserInfoResponseBody extends Model
{
    /**
     * @description 微应用免登用户所在企业id
     *
     * @var string
     */
    public $corpId;

    /**
     * @description 微应用免登用户所在企业名称
     *
     * @var string
     */
    public $corpName;

    /**
     * @description 用户id
     *
     * @var string
     */
    public $userId;

    /**
     * @description 用户邮箱
     *
     * @var string
     */
    public $email;

    /**
     * @description 用户名称
     *
     * @var string
     */
    public $userName;

    /**
     * @description 用户头像链接
     *
     * @var string
     */
    public $avatar;

    /**
     * @description 是否为企业管理员
     *
     * @var bool
     */
    public $isAdmin;
    protected $_name = [
        'corpId'   => 'corpId',
        'corpName' => 'corpName',
        'userId'   => 'userId',
        'email'    => 'email',
        'userName' => 'userName',
        'avatar'   => 'avatar',
        'isAdmin'  => 'isAdmin',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->corpName) {
            $res['corpName'] = $this->corpName;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->email) {
            $res['email'] = $this->email;
        }
        if (null !== $this->userName) {
            $res['userName'] = $this->userName;
        }
        if (null !== $this->avatar) {
            $res['avatar'] = $this->avatar;
        }
        if (null !== $this->isAdmin) {
            $res['isAdmin'] = $this->isAdmin;
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
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['corpName'])) {
            $model->corpName = $map['corpName'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['email'])) {
            $model->email = $map['email'];
        }
        if (isset($map['userName'])) {
            $model->userName = $map['userName'];
        }
        if (isset($map['avatar'])) {
            $model->avatar = $map['avatar'];
        }
        if (isset($map['isAdmin'])) {
            $model->isAdmin = $map['isAdmin'];
        }

        return $model;
    }
}
