<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\UpdateChecklistRuleResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\UpdateChecklistRuleResponseBody\data\rule;
use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @var rule
     */
    public $rule;
    protected $_name = [
        'rule' => 'rule',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->rule) {
            $res['rule'] = null !== $this->rule ? $this->rule->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['rule'])) {
            $model->rule = rule::fromMap($map['rule']);
        }

        return $model;
    }
}
