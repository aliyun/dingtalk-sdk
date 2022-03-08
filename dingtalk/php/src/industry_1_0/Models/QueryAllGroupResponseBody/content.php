<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllGroupResponseBody;

use AlibabaCloud\Tea\Model;

class content extends Model
{
    /**
     * @description 所在科室Id
     *
     * @var int
     */
    public $deptId;

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
    protected $_name = [
        'deptId' => 'deptId',
        'id'     => 'id',
        'name'   => 'name',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptId) {
            $res['deptId'] = $this->deptId;
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
     * @return content
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptId'])) {
            $model->deptId = $map['deptId'];
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
