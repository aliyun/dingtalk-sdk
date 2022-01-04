<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vfinance_1_0\Models\ModifySubInstitutionRequest\subInstInvoiceInfo;

use AlibabaCloud\Tea\Model;

class mailAddress extends Model
{
    /**
     * @description 省码
     *
     * @var string
     */
    public $provinceCode;

    /**
     * @description 市码
     *
     * @var string
     */
    public $cityCode;

    /**
     * @description 区码
     *
     * @var string
     */
    public $districtCode;

    /**
     * @description 详细地址
     *
     * @var string
     */
    public $address;
    protected $_name = [
        'provinceCode' => 'provinceCode',
        'cityCode'     => 'cityCode',
        'districtCode' => 'districtCode',
        'address'      => 'address',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->provinceCode) {
            $res['provinceCode'] = $this->provinceCode;
        }
        if (null !== $this->cityCode) {
            $res['cityCode'] = $this->cityCode;
        }
        if (null !== $this->districtCode) {
            $res['districtCode'] = $this->districtCode;
        }
        if (null !== $this->address) {
            $res['address'] = $this->address;
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
        if (isset($map['provinceCode'])) {
            $model->provinceCode = $map['provinceCode'];
        }
        if (isset($map['cityCode'])) {
            $model->cityCode = $map['cityCode'];
        }
        if (isset($map['districtCode'])) {
            $model->districtCode = $map['districtCode'];
        }
        if (isset($map['address'])) {
            $model->address = $map['address'];
        }

        return $model;
    }
}
