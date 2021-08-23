<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\ListDeptSimpleUsersResponseBody;

use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @var string
     */
    public $userId;

    /**
     * @var string
     */
    public $name;
    protected $_name = [
        'userId' => 'userId',
        'name'   => 'name',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return list_
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }

        return $model;
    }
}
