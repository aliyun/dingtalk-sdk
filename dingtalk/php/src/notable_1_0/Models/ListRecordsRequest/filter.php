<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\ListRecordsRequest;

use AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\ListRecordsRequest\filter\conditions;
use AlibabaCloud\Tea\Model;

class filter extends Model
{
    /**
     * @var string
     */
    public $combination;

    /**
     * @description This parameter is required.
     *
     * @var conditions[]
     */
    public $conditions;
    protected $_name = [
        'combination' => 'combination',
        'conditions' => 'conditions',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->combination) {
            $res['combination'] = $this->combination;
        }
        if (null !== $this->conditions) {
            $res['conditions'] = [];
            if (null !== $this->conditions && \is_array($this->conditions)) {
                $n = 0;
                foreach ($this->conditions as $item) {
                    $res['conditions'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return filter
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['combination'])) {
            $model->combination = $map['combination'];
        }
        if (isset($map['conditions'])) {
            if (!empty($map['conditions'])) {
                $model->conditions = [];
                $n = 0;
                foreach ($map['conditions'] as $item) {
                    $model->conditions[$n++] = null !== $item ? conditions::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
