<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\AddCollegeAlumniDeptsRequest\depts;
use AlibabaCloud\Tea\Model;

class AddCollegeAlumniDeptsRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var depts[]
     */
    public $depts;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $operator;
    protected $_name = [
        'depts'    => 'depts',
        'operator' => 'operator',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->depts) {
            $res['depts'] = [];
            if (null !== $this->depts && \is_array($this->depts)) {
                $n = 0;
                foreach ($this->depts as $item) {
                    $res['depts'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->operator) {
            $res['operator'] = $this->operator;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddCollegeAlumniDeptsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['depts'])) {
            if (!empty($map['depts'])) {
                $model->depts = [];
                $n            = 0;
                foreach ($map['depts'] as $item) {
                    $model->depts[$n++] = null !== $item ? depts::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['operator'])) {
            $model->operator = $map['operator'];
        }

        return $model;
    }
}
