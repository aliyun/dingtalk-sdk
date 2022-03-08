<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateCustomDeptRequest;

use AlibabaCloud\Tea\Model;

class customDept extends Model
{
    /**
     * @description 自定义校区或部门名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 部门类型：custom_campus: 自定义校区；custom_dept: 自定义部门
     *
     * @var string
     */
    public $type;
    protected $_name = [
        'name' => 'name',
        'type' => 'type',
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
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return customDept
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
