<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryExclusiveBenefitsResponseBody extends Model
{
    /**
     * @var string[]
     */
    public $benefitsList;
    protected $_name = [
        'benefitsList' => 'benefitsList',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->benefitsList) {
            $res['benefitsList'] = $this->benefitsList;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryExclusiveBenefitsResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['benefitsList'])) {
            if (!empty($map['benefitsList'])) {
                $model->benefitsList = $map['benefitsList'];
            }
        }

        return $model;
    }
}
