<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetTbUserIdByDingUserIdRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $dingUserIds;

    /**
     * @description This parameter is required.
     *
     * @example 0517xxx
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'dingUserIds' => 'dingUserIds',
        'userId'      => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dingUserIds) {
            $res['dingUserIds'] = $this->dingUserIds;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetTbUserIdByDingUserIdRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dingUserIds'])) {
            $model->dingUserIds = $map['dingUserIds'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
