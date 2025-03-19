<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetColumnvalsResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetColumnvalsResponseBody\result\columnData\columnValues;
use AlibabaCloud\Tea\Model;

class columnData extends Model
{
    /**
     * @var columnValues[]
     */
    public $columnValues;

    /**
     * @example 0
     *
     * @var string
     */
    public $fixedValue;

    /**
     * @example 129339038
     *
     * @var int
     */
    public $id;
    protected $_name = [
        'columnValues' => 'columnValues',
        'fixedValue' => 'fixedValue',
        'id' => 'id',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->columnValues) {
            $res['columnValues'] = [];
            if (null !== $this->columnValues && \is_array($this->columnValues)) {
                $n = 0;
                foreach ($this->columnValues as $item) {
                    $res['columnValues'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->fixedValue) {
            $res['fixedValue'] = $this->fixedValue;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return columnData
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['columnValues'])) {
            if (!empty($map['columnValues'])) {
                $model->columnValues = [];
                $n = 0;
                foreach ($map['columnValues'] as $item) {
                    $model->columnValues[$n++] = null !== $item ? columnValues::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['fixedValue'])) {
            $model->fixedValue = $map['fixedValue'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }

        return $model;
    }
}
