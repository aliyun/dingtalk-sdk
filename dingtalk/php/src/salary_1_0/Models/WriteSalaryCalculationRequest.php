<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vsalary_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vsalary_1_0\Models\WriteSalaryCalculationRequest\items;
use AlibabaCloud\Tea\Model;

class WriteSalaryCalculationRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 2025-06
     *
     * @var string
     */
    public $date;

    /**
     * @var items[]
     */
    public $items;
    protected $_name = [
        'date' => 'date',
        'items' => 'items',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->date) {
            $res['date'] = $this->date;
        }
        if (null !== $this->items) {
            $res['items'] = [];
            if (null !== $this->items && \is_array($this->items)) {
                $n = 0;
                foreach ($this->items as $item) {
                    $res['items'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return WriteSalaryCalculationRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['date'])) {
            $model->date = $map['date'];
        }
        if (isset($map['items'])) {
            if (!empty($map['items'])) {
                $model->items = [];
                $n = 0;
                foreach ($map['items'] as $item) {
                    $model->items[$n++] = null !== $item ? items::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
