<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models;

use AlibabaCloud\Tea\Model;

class AyunOnlienTestRequest extends Model
{
    /**
     * @var string
     */
    public $reqId;
    protected $_name = [
        'reqId' => 'reqId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->reqId) {
            $res['reqId'] = $this->reqId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AyunOnlienTestRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['reqId'])) {
            $model->reqId = $map['reqId'];
        }

        return $model;
    }
}
