<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class CopyUnfurlingRegisterRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 3102xxxxxxx
     *
     * @var string
     */
    public $appId;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $id;

    /**
     * @description This parameter is required.
     *
     * @example 37xxxxx
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'appId'  => 'appId',
        'id'     => 'id',
        'userId' => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appId) {
            $res['appId'] = $this->appId;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CopyUnfurlingRegisterRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appId'])) {
            $model->appId = $map['appId'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
