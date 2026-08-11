<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QuerySubjectPublicRiskResponseBody\result\risks\businessRisk;

use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QuerySubjectPublicRiskResponseBody\result\risks\businessRisk\subRisks\administrativePunishment;
use AlibabaCloud\Tea\Model;

class subRisks extends Model
{
    /**
     * @var administrativePunishment
     */
    public $administrativePunishment;
    protected $_name = [
        'administrativePunishment' => 'administrative_punishment',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->administrativePunishment) {
            $res['administrative_punishment'] = null !== $this->administrativePunishment ? $this->administrativePunishment->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return subRisks
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['administrative_punishment'])) {
            $model->administrativePunishment = administrativePunishment::fromMap($map['administrative_punishment']);
        }

        return $model;
    }
}
