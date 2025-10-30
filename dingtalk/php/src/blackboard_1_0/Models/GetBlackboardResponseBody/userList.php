<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vblackboard_1_0\Models\GetBlackboardResponseBody;

use AlibabaCloud\Tea\Model;

class userList extends Model
{
    /**
     * @example dingxxxx
     *
     * @var string
     */
    public $corpId;

    /**
     * @example 示例员工名称
     *
     * @var string
     */
    public $name;

    /**
     * @example manager01
     *
     * @var string
     */
    public $staffId;
    protected $_name = [
        'corpId' => 'corpId',
        'name' => 'name',
        'staffId' => 'staffId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->staffId) {
            $res['staffId'] = $this->staffId;
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
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['staffId'])) {
            $model->staffId = $map['staffId'];
        }

        return $model;
    }
}
