<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\ConsultCreateSubInstitutionRequest\subInstInvoiceInfo;

use AlibabaCloud\Tea\Model;

class mailAddress extends Model
{
    /**
     * @example 未来park
     *
     * @var string
     */
    public $address;

    /**
     * @example 330100
     *
     * @var string
     */
    public $cityCode;

    /**
     * @example 330104
     *
     * @var string
     */
    public $districtCode;

    /**
     * @example 330000
     *
     * @var string
     */
    public $provinceCode;
    protected $_name = [
        'address'      => 'address',
        'cityCode'     => 'cityCode',
        'districtCode' => 'districtCode',
        'provinceCode' => 'provinceCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->address) {
            $res['address'] = $this->address;
        }
        if (null !== $this->cityCode) {
            $res['cityCode'] = $this->cityCode;
        }
        if (null !== $this->districtCode) {
            $res['districtCode'] = $this->districtCode;
        }
        if (null !== $this->provinceCode) {
            $res['provinceCode'] = $this->provinceCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return mailAddress
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['address'])) {
            $model->address = $map['address'];
        }
        if (isset($map['cityCode'])) {
            $model->cityCode = $map['cityCode'];
        }
        if (isset($map['districtCode'])) {
            $model->districtCode = $map['districtCode'];
        }
        if (isset($map['provinceCode'])) {
            $model->provinceCode = $map['provinceCode'];
        }

        return $model;
    }
}
