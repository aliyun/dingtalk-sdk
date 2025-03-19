<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class DebugUnfurlingRegisterRequest extends Model
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
     * @var string[]
     */
    public $grayGroupIdList;

    /**
     * @var string[]
     */
    public $grayUserIdList;

    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var int
     */
    public $id;

    /**
     * @description This parameter is required.
     *
     * @example 37xxxx
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'appId' => 'appId',
        'grayGroupIdList' => 'grayGroupIdList',
        'grayUserIdList' => 'grayUserIdList',
        'id' => 'id',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->appId) {
            $res['appId'] = $this->appId;
        }
        if (null !== $this->grayGroupIdList) {
            $res['grayGroupIdList'] = $this->grayGroupIdList;
        }
        if (null !== $this->grayUserIdList) {
            $res['grayUserIdList'] = $this->grayUserIdList;
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
     * @return DebugUnfurlingRegisterRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appId'])) {
            $model->appId = $map['appId'];
        }
        if (isset($map['grayGroupIdList'])) {
            if (!empty($map['grayGroupIdList'])) {
                $model->grayGroupIdList = $map['grayGroupIdList'];
            }
        }
        if (isset($map['grayUserIdList'])) {
            if (!empty($map['grayUserIdList'])) {
                $model->grayUserIdList = $map['grayUserIdList'];
            }
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
