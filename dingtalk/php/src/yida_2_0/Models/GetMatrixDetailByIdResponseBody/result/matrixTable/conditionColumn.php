<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_2_0\Models\GetMatrixDetailByIdResponseBody\result\matrixTable;

use AlibabaCloud\Tea\Model;

class conditionColumn extends Model
{
    /**
     * @var string
     */
    public $columnId;

    /**
     * @var string
     */
    public $componentType;

    /**
     * @var string
     */
    public $name;
    protected $_name = [
        'columnId' => 'columnId',
        'componentType' => 'componentType',
        'name' => 'name',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->columnId) {
            $res['columnId'] = $this->columnId;
        }
        if (null !== $this->componentType) {
            $res['componentType'] = $this->componentType;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return conditionColumn
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['columnId'])) {
            $model->columnId = $map['columnId'];
        }
        if (isset($map['componentType'])) {
            $model->componentType = $map['componentType'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }

        return $model;
    }
}
