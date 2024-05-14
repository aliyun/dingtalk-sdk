<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetVillageOrgInfoResponseBody extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $regionId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $regionLocation;

    /**
     * @description This parameter is required.
     *
     * @example 省份：PROVINCE;城市：CITY;县区：COUNTRY;乡镇：TOWN;村：VILLAGE
     *
     * @var string
     */
    public $regionType;
    protected $_name = [
        'regionId'       => 'regionId',
        'regionLocation' => 'regionLocation',
        'regionType'     => 'regionType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->regionId) {
            $res['regionId'] = $this->regionId;
        }
        if (null !== $this->regionLocation) {
            $res['regionLocation'] = $this->regionLocation;
        }
        if (null !== $this->regionType) {
            $res['regionType'] = $this->regionType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetVillageOrgInfoResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['regionId'])) {
            $model->regionId = $map['regionId'];
        }
        if (isset($map['regionLocation'])) {
            $model->regionLocation = $map['regionLocation'];
        }
        if (isset($map['regionType'])) {
            $model->regionType = $map['regionType'];
        }

        return $model;
    }
}
