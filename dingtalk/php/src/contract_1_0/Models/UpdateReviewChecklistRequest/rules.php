<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\UpdateReviewChecklistRequest;

use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\UpdateReviewChecklistRequest\rules\items;
use AlibabaCloud\Tea\Model;

class rules extends Model
{
    /**
     * @var bool
     */
    public $custom;

    /**
     * @var string
     */
    public $description;

    /**
     * @var string
     */
    public $id;

    /**
     * @var items[]
     */
    public $items;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $riskLevel;

    /**
     * @var string
     */
    public $standpoint;
    protected $_name = [
        'custom' => 'custom',
        'description' => 'description',
        'id' => 'id',
        'items' => 'items',
        'name' => 'name',
        'riskLevel' => 'risk_level',
        'standpoint' => 'standpoint',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->custom) {
            $res['custom'] = $this->custom;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
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
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->riskLevel) {
            $res['risk_level'] = $this->riskLevel;
        }
        if (null !== $this->standpoint) {
            $res['standpoint'] = $this->standpoint;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return rules
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['custom'])) {
            $model->custom = $map['custom'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
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
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['risk_level'])) {
            $model->riskLevel = $map['risk_level'];
        }
        if (isset($map['standpoint'])) {
            $model->standpoint = $map['standpoint'];
        }

        return $model;
    }
}
