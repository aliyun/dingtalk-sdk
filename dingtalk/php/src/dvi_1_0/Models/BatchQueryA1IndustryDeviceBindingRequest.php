<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models;

use AlibabaCloud\Tea\Model;

class BatchQueryA1IndustryDeviceBindingRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $snList;
    protected $_name = [
        'snList' => 'snList',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->snList) {
            $res['snList'] = $this->snList;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BatchQueryA1IndustryDeviceBindingRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['snList'])) {
            if (!empty($map['snList'])) {
                $model->snList = $map['snList'];
            }
        }

        return $model;
    }
}
