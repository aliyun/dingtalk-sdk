<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\UpdateReviewChecklistResponseBody\data\checklist\rules;

use AlibabaCloud\Tea\Model;

class items extends Model
{
    /**
     * @var string
     */
    public $criteria;

    /**
     * @var bool
     */
    public $enabled;

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
    public $severity;
    protected $_name = [
        'criteria' => 'criteria',
        'enabled' => 'enabled',
        'id' => 'id',
        'name' => 'name',
        'severity' => 'severity',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->criteria) {
            $res['criteria'] = $this->criteria;
        }
        if (null !== $this->enabled) {
            $res['enabled'] = $this->enabled;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->severity) {
            $res['severity'] = $this->severity;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return items
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['criteria'])) {
            $model->criteria = $map['criteria'];
        }
        if (isset($map['enabled'])) {
            $model->enabled = $map['enabled'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['severity'])) {
            $model->severity = $map['severity'];
        }

        return $model;
    }
}
