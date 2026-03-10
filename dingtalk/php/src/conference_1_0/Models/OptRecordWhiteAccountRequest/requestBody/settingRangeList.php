<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\OptRecordWhiteAccountRequest\requestBody;

use AlibabaCloud\Tea\Model;

class settingRangeList extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example vLY8xxxxxxxQiEiE
     *
     * @var string
     */
    public $settingRangeId;

    /**
     * @description This parameter is required.
     *
     * @example 3
     *
     * @var int
     */
    public $settingRangeType;
    protected $_name = [
        'settingRangeId' => 'settingRangeId',
        'settingRangeType' => 'settingRangeType',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->settingRangeId) {
            $res['settingRangeId'] = $this->settingRangeId;
        }
        if (null !== $this->settingRangeType) {
            $res['settingRangeType'] = $this->settingRangeType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return settingRangeList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['settingRangeId'])) {
            $model->settingRangeId = $map['settingRangeId'];
        }
        if (isset($map['settingRangeType'])) {
            $model->settingRangeType = $map['settingRangeType'];
        }

        return $model;
    }
}
