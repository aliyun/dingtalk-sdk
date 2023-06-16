<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class RollbackDeductPointRequest extends Model
{
    /**
     * @example biz01
     *
     * @var string
     */
    public $bizId;

    /**
     * @example personal
     *
     * @var string
     */
    public $pointType;
    protected $_name = [
        'bizId'     => 'bizId',
        'pointType' => 'pointType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
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
     * @return RollbackDeductPointRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizId'])) {
            $model->bizId = $map['bizId'];
        }
        if (isset($map['pointType'])) {
            $model->pointType = $map['pointType'];
        }

        return $model;
    }
}
