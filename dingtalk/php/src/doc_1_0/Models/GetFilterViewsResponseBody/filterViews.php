<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\GetFilterViewsResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\FilterViewsCriteriaValue;
use AlibabaCloud\Tea\Model;

class filterViews extends Model
{
    /**
     * @var FilterViewsCriteriaValue[]
     */
    public $criteria;

    /**
     * @var string
     */
    public $id;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $range;
    protected $_name = [
        'criteria' => 'criteria',
        'id' => 'id',
        'name' => 'name',
        'range' => 'range',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->criteria) {
            $res['criteria'] = [];
            if (null !== $this->criteria && \is_array($this->criteria)) {
                foreach ($this->criteria as $key => $val) {
                    $res['criteria'][$key] = null !== $val ? $val->toMap() : $val;
                }
            }
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->range) {
            $res['range'] = $this->range;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return filterViews
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['criteria'])) {
            $model->criteria = $map['criteria'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['range'])) {
            $model->range = $map['range'];
        }

        return $model;
    }
}
