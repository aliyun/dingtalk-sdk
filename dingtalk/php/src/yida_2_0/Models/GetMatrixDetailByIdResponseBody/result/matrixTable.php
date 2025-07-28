<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_2_0\Models\GetMatrixDetailByIdResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vyida_2_0\Models\GetMatrixDetailByIdResponseBody\result\matrixTable\conditionColumn;
use AlibabaCloud\SDK\Dingtalk\Vyida_2_0\Models\GetMatrixDetailByIdResponseBody\result\matrixTable\resultColumn;
use AlibabaCloud\Tea\Model;

class matrixTable extends Model
{
    /**
     * @var conditionColumn[]
     */
    public $conditionColumn;

    /**
     * @var resultColumn[]
     */
    public $resultColumn;
    protected $_name = [
        'conditionColumn' => 'conditionColumn',
        'resultColumn' => 'resultColumn',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->conditionColumn) {
            $res['conditionColumn'] = [];
            if (null !== $this->conditionColumn && \is_array($this->conditionColumn)) {
                $n = 0;
                foreach ($this->conditionColumn as $item) {
                    $res['conditionColumn'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->resultColumn) {
            $res['resultColumn'] = [];
            if (null !== $this->resultColumn && \is_array($this->resultColumn)) {
                $n = 0;
                foreach ($this->resultColumn as $item) {
                    $res['resultColumn'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return matrixTable
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['conditionColumn'])) {
            if (!empty($map['conditionColumn'])) {
                $model->conditionColumn = [];
                $n = 0;
                foreach ($map['conditionColumn'] as $item) {
                    $model->conditionColumn[$n++] = null !== $item ? conditionColumn::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['resultColumn'])) {
            if (!empty($map['resultColumn'])) {
                $model->resultColumn = [];
                $n = 0;
                foreach ($map['resultColumn'] as $item) {
                    $model->resultColumn[$n++] = null !== $item ? resultColumn::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
