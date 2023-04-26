<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CollegeListDeptManagerResponseBody;

use AlibabaCloud\Tea\Model;

class managerInfoSimpleList extends Model
{
    /**
     * @var bool
     */
    public $isActive;

    /**
     * @example 张三
     *
     * @var string
     */
    public $name;

    /**
     * @example 0324124
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'isActive' => 'isActive',
        'name'     => 'name',
        'userId'   => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->isActive) {
            $res['isActive'] = $this->isActive;
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
     * @return managerInfoSimpleList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['isActive'])) {
            $model->isActive = $map['isActive'];
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
