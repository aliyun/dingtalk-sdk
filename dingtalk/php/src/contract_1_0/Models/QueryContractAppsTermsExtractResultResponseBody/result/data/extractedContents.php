<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QueryContractAppsTermsExtractResultResponseBody\result\data;

use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QueryContractAppsTermsExtractResultResponseBody\result\data\extractedContents\termContents;
use AlibabaCloud\Tea\Model;

class extractedContents extends Model
{
    /**
     * @var string
     */
    public $ruleCategory;

    /**
     * @var termContents[]
     */
    public $termContents;
    protected $_name = [
        'ruleCategory' => 'ruleCategory',
        'termContents' => 'termContents',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->ruleCategory) {
            $res['ruleCategory'] = $this->ruleCategory;
        }
        if (null !== $this->termContents) {
            $res['termContents'] = [];
            if (null !== $this->termContents && \is_array($this->termContents)) {
                $n = 0;
                foreach ($this->termContents as $item) {
                    $res['termContents'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return extractedContents
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['ruleCategory'])) {
            $model->ruleCategory = $map['ruleCategory'];
        }
        if (isset($map['termContents'])) {
            if (!empty($map['termContents'])) {
                $model->termContents = [];
                $n = 0;
                foreach ($map['termContents'] as $item) {
                    $model->termContents[$n++] = null !== $item ? termContents::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
