<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\OptRecordWhiteAccountRequest;

use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\OptRecordWhiteAccountRequest\requestBody\settingRangeList;
use AlibabaCloud\Tea\Model;

class requestBody extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example cloud_record
     *
     * @var string
     */
    public $bizType;

    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var int
     */
    public $operation;

    /**
     * @var settingRangeList[]
     */
    public $settingRangeList;

    /**
     * @description This parameter is required.
     *
     * @example vLXXXiEiE
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'bizType' => 'bizType',
        'operation' => 'operation',
        'settingRangeList' => 'settingRangeList',
        'unionId' => 'unionId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizType) {
            $res['bizType'] = $this->bizType;
        }
        if (null !== $this->operation) {
            $res['operation'] = $this->operation;
        }
        if (null !== $this->settingRangeList) {
            $res['settingRangeList'] = [];
            if (null !== $this->settingRangeList && \is_array($this->settingRangeList)) {
                $n = 0;
                foreach ($this->settingRangeList as $item) {
                    $res['settingRangeList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return requestBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizType'])) {
            $model->bizType = $map['bizType'];
        }
        if (isset($map['operation'])) {
            $model->operation = $map['operation'];
        }
        if (isset($map['settingRangeList'])) {
            if (!empty($map['settingRangeList'])) {
                $model->settingRangeList = [];
                $n = 0;
                foreach ($map['settingRangeList'] as $item) {
                    $model->settingRangeList[$n++] = null !== $item ? settingRangeList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
