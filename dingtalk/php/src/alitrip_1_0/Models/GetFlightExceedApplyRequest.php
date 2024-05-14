<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetFlightExceedApplyRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 1234
     *
     * @var string
     */
    public $applyId;

    /**
     * @description This parameter is required.
     *
     * @example ding1234
     *
     * @var string
     */
    public $corpId;
    protected $_name = [
        'applyId' => 'applyId',
        'corpId'  => 'corpId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->applyId) {
            $res['applyId'] = $this->applyId;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetFlightExceedApplyRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['applyId'])) {
            $model->applyId = $map['applyId'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }

        return $model;
    }
}
