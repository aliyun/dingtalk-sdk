<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models;

use AlibabaCloud\Tea\Model;

class AddProfileRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $appUid;

    /**
     * @var string
     */
    public $avatarMediaId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $mobileNumber;

    /**
     * @description This parameter is required.
     *
     * @example usertest
     *
     * @var string
     */
    public $nick;
    protected $_name = [
        'appUid' => 'appUid',
        'avatarMediaId' => 'avatarMediaId',
        'mobileNumber' => 'mobileNumber',
        'nick' => 'nick',
    ];

    public function validate() {}

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
