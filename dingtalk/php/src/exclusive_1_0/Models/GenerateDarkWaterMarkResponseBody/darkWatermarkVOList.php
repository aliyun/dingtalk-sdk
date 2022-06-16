<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GenerateDarkWaterMarkResponseBody;

use AlibabaCloud\Tea\Model;

class darkWatermarkVOList extends Model
{
    /**
     * @description 暗水印链接
     *
     * @var string
     */
    public $darkWatermark;

    /**
     * @description 员工工号
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'darkWatermark' => 'darkWatermark',
        'userId'        => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->darkWatermark) {
            $res['darkWatermark'] = $this->darkWatermark;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return darkWatermarkVOList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['darkWatermark'])) {
            $model->darkWatermark = $map['darkWatermark'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
