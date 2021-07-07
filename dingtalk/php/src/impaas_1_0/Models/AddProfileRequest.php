<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models;

use AlibabaCloud\Tea\Model;

class AddProfileRequest extends Model
{
    /**
     * @description 昵称
     *
     * @var string
     */
    public $nick;

    /**
     * @description 头像mediaId，调用Upload接口获得
     *
     * @var string
     */
    public $avatarMediaId;

    /**
     * @description 外部app的账号，格式：xxx@channel格式
     *
     * @var string
     */
    public $appUid;

    /**
     * @description 手机号
     *
     * @var string
     */
    public $mobileNumber;
    protected $_name = [
        'nick'          => 'nick',
        'avatarMediaId' => 'avatarMediaId',
        'appUid'        => 'appUid',
        'mobileNumber'  => 'mobileNumber',
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
        if (null !== $this->avatarMediaId) {
            $res['avatarMediaId'] = $this->avatarMediaId;
        }
        if (null !== $this->appUid) {
            $res['appUid'] = $this->appUid;
        }
        if (null !== $this->mobileNumber) {
            $res['mobileNumber'] = $this->mobileNumber;
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
        if (isset($map['nick'])) {
            $model->nick = $map['nick'];
        }
        if (isset($map['avatarMediaId'])) {
            $model->avatarMediaId = $map['avatarMediaId'];
        }
        if (isset($map['appUid'])) {
            $model->appUid = $map['appUid'];
        }
        if (isset($map['mobileNumber'])) {
            $model->mobileNumber = $map['mobileNumber'];
        }

        return $model;
    }
}
