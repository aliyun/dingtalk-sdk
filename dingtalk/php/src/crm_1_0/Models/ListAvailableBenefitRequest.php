<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListAvailableBenefitRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $benefitCodeList;
    protected $_name = [
        'benefitCodeList' => 'benefitCodeList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->benefitCodeList) {
            $res['benefitCodeList'] = $this->benefitCodeList;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListAvailableBenefitRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['benefitCodeList'])) {
            if (!empty($map['benefitCodeList'])) {
                $model->benefitCodeList = $map['benefitCodeList'];
            }
        }

        return $model;
    }
}
