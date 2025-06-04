<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\CreateContractAppsTermsExtractEaskRequest;

use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\CreateContractAppsTermsExtractEaskRequest\extractRules\termRules;
use AlibabaCloud\Tea\Model;

class extractRules extends Model
{
    /**
     * @var string
     */
    public $ruleCategory;

    /**
     * @var termRules[]
     */
    public $termRules;
    protected $_name = [
        'ruleCategory' => 'ruleCategory',
        'termRules' => 'termRules',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->ruleCategory) {
            $res['ruleCategory'] = $this->ruleCategory;
        }
        if (null !== $this->termRules) {
            $res['termRules'] = [];
            if (null !== $this->termRules && \is_array($this->termRules)) {
                $n = 0;
                foreach ($this->termRules as $item) {
                    $res['termRules'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return extractRules
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['ruleCategory'])) {
            $model->ruleCategory = $map['ruleCategory'];
        }
        if (isset($map['termRules'])) {
            if (!empty($map['termRules'])) {
                $model->termRules = [];
                $n = 0;
                foreach ($map['termRules'] as $item) {
                    $model->termRules[$n++] = null !== $item ? termRules::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
