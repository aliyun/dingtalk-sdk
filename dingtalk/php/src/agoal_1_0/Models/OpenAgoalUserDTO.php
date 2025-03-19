<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models;

use AlibabaCloud\Tea\Model;

class OpenAgoalUserDTO extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 211042291978xxxx
     *
     * @var string
     */
    public $dingUserId;

    /**
     * @description This parameter is required.
     *
     * @example 测试
     *
     * @var string
     */
    public $name;

    /**
     * @description This parameter is required.
     *
     * @example 6444f5e9a4261c6e699dxxxx
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'dingUserId' => 'dingUserId',
        'name' => 'name',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->dingUserId) {
            $res['dingUserId'] = $this->dingUserId;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OpenAgoalUserDTO
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dingUserId'])) {
            $model->dingUserId = $map['dingUserId'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
