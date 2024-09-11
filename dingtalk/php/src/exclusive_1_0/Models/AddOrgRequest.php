<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class AddOrgRequest extends Model
{
    /**
     * @var string
     */
    public $city;

    /**
     * @var string
     */
    public $industry;

    /**
     * @var int
     */
    public $industryCode;

    /**
     * @description This parameter is required.
     *
     * @example 15800000000
     *
     * @var string
     */
    public $mobileNum;

    /**
     * @description This parameter is required.
     *
     * @example 测试组织
     *
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $province;
    protected $_name = [
        'city'         => 'city',
        'industry'     => 'industry',
        'industryCode' => 'industryCode',
        'mobileNum'    => 'mobileNum',
        'name'         => 'name',
        'province'     => 'province',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->city) {
            $res['city'] = $this->city;
        }
        if (null !== $this->industry) {
            $res['industry'] = $this->industry;
        }
        if (null !== $this->industryCode) {
            $res['industryCode'] = $this->industryCode;
        }
        if (null !== $this->mobileNum) {
            $res['mobileNum'] = $this->mobileNum;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->province) {
            $res['province'] = $this->province;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddOrgRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['city'])) {
            $model->city = $map['city'];
        }
        if (isset($map['industry'])) {
            $model->industry = $map['industry'];
        }
        if (isset($map['industryCode'])) {
            $model->industryCode = $map['industryCode'];
        }
        if (isset($map['mobileNum'])) {
            $model->mobileNum = $map['mobileNum'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['province'])) {
            $model->province = $map['province'];
        }

        return $model;
    }
}
