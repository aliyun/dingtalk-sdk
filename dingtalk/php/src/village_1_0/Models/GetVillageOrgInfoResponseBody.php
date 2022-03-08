<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetVillageOrgInfoResponseBody extends Model
{
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

    /**
     * @description 区域类型
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
