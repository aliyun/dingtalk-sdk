<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmeter_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetResourceUseInfoRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $benefitCodeList;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $period;
    protected $_name = [
        'benefitCodeList' => 'benefitCodeList',
        'period' => 'period',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->benefitCodeList) {
            $res['benefitCodeList'] = $this->benefitCodeList;
        }
        if (null !== $this->period) {
            $res['period'] = $this->period;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetResourceUseInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['benefitCodeList'])) {
            if (!empty($map['benefitCodeList'])) {
                $model->benefitCodeList = $map['benefitCodeList'];
            }
        }
        if (isset($map['period'])) {
            $model->period = $map['period'];
        }

        return $model;
    }
}
