<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models;

use AlibabaCloud\Tea\Model;

class AddProfileRequest extends Model
{
    /**
     * @description 外部app的账号，格式：xxx@channel格式
     *
     * @var string
     */
    public $appUid;

    /**
     * @description 头像mediaId，调用Upload接口获得
     *
     * @var string
     */
    public $avatarMediaId;

    /**
     * @description 手机号
     *
     * @var string
     */
    public $mobileNumber;

    /**
     * @description 昵称
     *
     * @var string
     */
    public $nick;
    protected $_name = [
        'appUid'        => 'appUid',
        'avatarMediaId' => 'avatarMediaId',
        'mobileNumber'  => 'mobileNumber',
        'nick'          => 'nick',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appUid) {
            $res['appUid'] = $this->appUid;
        }
        if (null !== $this->avatarMediaId) {
            $res['avatarMediaId'] = $this->avatarMediaId;
        }
        if (null !== $this->mobileNumber) {
            $res['mobileNumber'] = $this->mobileNumber;
        }
        if (null !== $this->nick) {
            $res['nick'] = $this->nick;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddProfileRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appUid'])) {
            $model->appUid = $map['appUid'];
        }
        if (isset($map['avatarMediaId'])) {
            $model->avatarMediaId = $map['avatarMediaId'];
        }
        if (isset($map['mobileNumber'])) {
            $model->mobileNumber = $map['mobileNumber'];
        }
        if (isset($map['nick'])) {
            $model->nick = $map['nick'];
        }

        return $model;
    }
}
