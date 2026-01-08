<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models;

use AlibabaCloud\Tea\Model;

class HrbrainLabelMetaStatusRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $codes;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $optType;
    protected $_name = [
        'codes' => 'codes',
        'optType' => 'optType',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->codes) {
            $res['codes'] = $this->codes;
        }
        if (null !== $this->optType) {
            $res['optType'] = $this->optType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return HrbrainLabelMetaStatusRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['codes'])) {
            if (!empty($map['codes'])) {
                $model->codes = $map['codes'];
            }
        }
        if (isset($map['optType'])) {
            $model->optType = $map['optType'];
        }

        return $model;
    }
}
