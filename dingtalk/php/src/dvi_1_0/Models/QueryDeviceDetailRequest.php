<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryDeviceDetailRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example A1
     *
     * @var string
     */
    public $deviceType;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $snList;
    protected $_name = [
        'deviceType' => 'deviceType',
        'snList' => 'snList',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->deviceType) {
            $res['deviceType'] = $this->deviceType;
        }
        if (null !== $this->snList) {
            $res['snList'] = $this->snList;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryDeviceDetailRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deviceType'])) {
            $model->deviceType = $map['deviceType'];
        }
        if (isset($map['snList'])) {
            if (!empty($map['snList'])) {
                $model->snList = $map['snList'];
            }
        }

        return $model;
    }
}
