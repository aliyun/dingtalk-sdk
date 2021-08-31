<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\ListSubDeptResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 下属组织的部门ID
     *
     * @var int
     */
    public $departmentId;

    /**
     * @description 部门名称
     *
     * @var string
     */
    public $name;
    protected $_name = [
        'departmentId' => 'departmentId',
        'name'         => 'name',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->departmentId) {
            $res['departmentId'] = $this->departmentId;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['departmentId'])) {
            $model->departmentId = $map['departmentId'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }

        return $model;
    }
}
