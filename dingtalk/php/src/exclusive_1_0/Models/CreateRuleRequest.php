<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\CreateRuleRequest\customPlan;
use AlibabaCloud\Tea\Model;

class CreateRuleRequest extends Model
{
    /**
     * @var customPlan
     */
    public $customPlan;
    protected $_name = [
        'customPlan' => 'customPlan',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->customPlan) {
            $res['customPlan'] = null !== $this->customPlan ? $this->customPlan->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateRuleRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['customPlan'])) {
            $model->customPlan = customPlan::fromMap($map['customPlan']);
        }

        return $model;
    }
}
