<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\GetTravelProcessDetailResponseBody\result\journeys;

use AlibabaCloud\Tea\Model;

class arrival extends Model
{
    /**
     * @example TSN
     *
     * @var string
     */
    public $code;

    /**
     * @example CN
     *
     * @var string
     */
    public $countryCode;

    /**
     * @example 中国
     *
     * @var string
     */
    public $countryName;

    /**
     * @example 天津市
     *
     * @var string
     */
    public $name;

    /**
     * @example 120000
     *
     * @var string
     */
    public $nationalCityCode;
    protected $_name = [
        'code'             => 'code',
        'countryCode'      => 'countryCode',
        'countryName'      => 'countryName',
        'name'             => 'name',
        'nationalCityCode' => 'nationalCityCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->code) {
            $res['code'] = $this->code;
        }
        if (null !== $this->countryCode) {
            $res['countryCode'] = $this->countryCode;
        }
        if (null !== $this->countryName) {
            $res['countryName'] = $this->countryName;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->nationalCityCode) {
            $res['nationalCityCode'] = $this->nationalCityCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return arrival
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }
        if (isset($map['countryCode'])) {
            $model->countryCode = $map['countryCode'];
        }
        if (isset($map['countryName'])) {
            $model->countryName = $map['countryName'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['nationalCityCode'])) {
            $model->nationalCityCode = $map['nationalCityCode'];
        }

        return $model;
    }
}
