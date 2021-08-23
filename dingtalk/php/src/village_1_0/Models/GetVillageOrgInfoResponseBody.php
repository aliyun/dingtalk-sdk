<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetVillageOrgInfoResponseBody extends Model
{
    /**
     * @description 区域类型
     *
     * @var string
     */
    public $regionType;

    /**
     * @description 行政区ID
     *
     * @var string
     */
    public $regionId;

    /**
     * @description 具体的企业区域位置信息
     *
     * @var string
     */
    public $regionLocation;
    protected $_name = [
        'regionType'     => 'regionType',
        'regionId'       => 'regionId',
        'regionLocation' => 'regionLocation',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->regionType) {
            $res['regionType'] = $this->regionType;
        }
        if (null !== $this->regionId) {
            $res['regionId'] = $this->regionId;
        }
        if (null !== $this->regionLocation) {
            $res['regionLocation'] = $this->regionLocation;
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
        if (isset($map['regionType'])) {
            $model->regionType = $map['regionType'];
        }
        if (isset($map['regionId'])) {
            $model->regionId = $map['regionId'];
        }
        if (isset($map['regionLocation'])) {
            $model->regionLocation = $map['regionLocation'];
        }

        return $model;
    }
}
