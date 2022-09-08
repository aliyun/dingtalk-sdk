<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\ListFollowerResponseBody\result;

use AlibabaCloud\Tea\Model;

class userList extends Model
{
    /**
     * @description 关注者昵称
     *
     * @var string
     */
    public $name;

    /**
     * @description 关注时间
     *
     * @var int
     */
    public $timestamp;

    /**
     * @description 关注者userId，可用于消息推送等场景。
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'name'      => 'name',
        'timestamp' => 'timestamp',
        'userId'    => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->timestamp) {
            $res['timestamp'] = $this->timestamp;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return userList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['timestamp'])) {
            $model->timestamp = $map['timestamp'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
