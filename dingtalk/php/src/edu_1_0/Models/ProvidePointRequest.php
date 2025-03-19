<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class ProvidePointRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example action01
     *
     * @var string
     */
    public $actionCode;

    /**
     * @description This parameter is required.
     *
     * @example biz01
     *
     * @var string
     */
    public $bizId;

    /**
     * @description This parameter is required.
     *
     * @example personal
     *
     * @var string
     */
    public $pointType;
    protected $_name = [
        'actionCode' => 'actionCode',
        'bizId' => 'bizId',
        'pointType' => 'pointType',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->actionCode) {
            $res['actionCode'] = $this->actionCode;
        }
        if (null !== $this->bizId) {
            $res['bizId'] = $this->bizId;
        }
        if (null !== $this->pointType) {
            $res['pointType'] = $this->pointType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ProvidePointRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['actionCode'])) {
            $model->actionCode = $map['actionCode'];
        }
        if (isset($map['bizId'])) {
            $model->bizId = $map['bizId'];
        }
        if (isset($map['pointType'])) {
            $model->pointType = $map['pointType'];
        }

        return $model;
    }
}
