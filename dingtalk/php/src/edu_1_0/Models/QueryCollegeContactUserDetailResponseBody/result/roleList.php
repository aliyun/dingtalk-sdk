<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryCollegeContactUserDetailResponseBody\result;

use AlibabaCloud\Tea\Model;

class roleList extends Model
{
    /**
     * @example 职务
     *
     * @var string
     */
    public $groupName;

    /**
     * @example 100
     *
     * @var int
     */
    public $id;

    /**
     * @example 宿舍长
     *
     * @var string
     */
    public $name;
    protected $_name = [
        'groupName' => 'groupName',
        'id'        => 'id',
        'name'      => 'name',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->groupName) {
            $res['groupName'] = $this->groupName;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return roleList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['groupName'])) {
            $model->groupName = $map['groupName'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }

        return $model;
    }
}
