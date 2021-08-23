<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\ListResidentSubDeptsResponseBody;

use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @var int
     */
    public $deptId;

    /**
     * @var string
     */
    public $name;

    /**
     * @var int
     */
    public $superId;
    protected $_name = [
        'deptId'  => 'deptId',
        'name'    => 'name',
        'superId' => 'superId',
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
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->superId) {
            $res['superId'] = $this->superId;
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
        if (isset($map['deptId'])) {
            $model->deptId = $map['deptId'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['superId'])) {
            $model->superId = $map['superId'];
        }

        return $model;
    }
}
