<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models;

use AlibabaCloud\Tea\Model;

class LinkCommonInvokeResponseBody extends Model
{
    /**
     * @var string
     */
    public $bizType;

    /**
     * @var string
     */
    public $data;

    /**
     * @var string
     */
    public $invokeId;
    protected $_name = [
        'bizType' => 'bizType',
        'data' => 'data',
        'invokeId' => 'invokeId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizType) {
            $res['bizType'] = $this->bizType;
        }
        if (null !== $this->data) {
            $res['data'] = $this->data;
        }
        if (null !== $this->invokeId) {
            $res['invokeId'] = $this->invokeId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return LinkCommonInvokeResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizType'])) {
            $model->bizType = $map['bizType'];
        }
        if (isset($map['data'])) {
            $model->data = $map['data'];
        }
        if (isset($map['invokeId'])) {
            $model->invokeId = $map['invokeId'];
        }

        return $model;
    }
}
