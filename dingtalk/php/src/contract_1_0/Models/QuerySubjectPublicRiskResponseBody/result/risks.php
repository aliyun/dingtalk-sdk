<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QuerySubjectPublicRiskResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QuerySubjectPublicRiskResponseBody\result\risks\businessRisk;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QuerySubjectPublicRiskResponseBody\result\risks\justiceRisk;
use AlibabaCloud\Tea\Model;

class risks extends Model
{
    /**
     * @var businessRisk
     */
    public $businessRisk;

    /**
     * @var justiceRisk
     */
    public $justiceRisk;
    protected $_name = [
        'businessRisk' => 'business_risk',
        'justiceRisk' => 'justice_risk',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->businessRisk) {
            $res['business_risk'] = null !== $this->businessRisk ? $this->businessRisk->toMap() : null;
        }
        if (null !== $this->justiceRisk) {
            $res['justice_risk'] = null !== $this->justiceRisk ? $this->justiceRisk->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return risks
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['business_risk'])) {
            $model->businessRisk = businessRisk::fromMap($map['business_risk']);
        }
        if (isset($map['justice_risk'])) {
            $model->justiceRisk = justiceRisk::fromMap($map['justice_risk']);
        }

        return $model;
    }
}
