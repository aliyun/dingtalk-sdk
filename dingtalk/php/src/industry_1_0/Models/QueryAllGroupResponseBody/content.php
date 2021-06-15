<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllGroupResponseBody;

use AlibabaCloud\Tea\Model;

class content extends Model
{
    /**
     * @description 医疗组Id
     *
     * @var int
     */
    public $id;

    /**
     * @description 医疗组名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 所在科室Id
     *
     * @var int
     */
    public $deptId;
    protected $_name = [
        'id'     => 'id',
        'name'   => 'name',
        'deptId' => 'deptId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->deptId) {
            $res['deptId'] = $this->deptId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return content
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['deptId'])) {
            $model->deptId = $map['deptId'];
        }

        return $model;
    }
}
