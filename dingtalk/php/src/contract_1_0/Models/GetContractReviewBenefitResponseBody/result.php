<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\GetContractReviewBenefitResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\GetContractReviewBenefitResponseBody\result\benefitResponses;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var benefitResponses[]
     */
    public $benefitResponses;
    protected $_name = [
        'benefitResponses' => 'benefitResponses',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->benefitResponses) {
            $res['benefitResponses'] = [];
            if (null !== $this->benefitResponses && \is_array($this->benefitResponses)) {
                $n = 0;
                foreach ($this->benefitResponses as $item) {
                    $res['benefitResponses'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['benefitResponses'])) {
            if (!empty($map['benefitResponses'])) {
                $model->benefitResponses = [];
                $n = 0;
                foreach ($map['benefitResponses'] as $item) {
                    $model->benefitResponses[$n++] = null !== $item ? benefitResponses::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
