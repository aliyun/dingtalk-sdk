<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models;

use AlibabaCloud\Tea\Model;

class LoadBizObjectRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 193f9efea-e27b-427d-bd13-e3be65e00ef9
     *
     * @var string
     */
    public $bizObjectId;

    /**
     * @description This parameter is required.
     *
     * @example D0001839bbbbe346bbf496498bb76c44c7eb972
     *
     * @var string
     */
    public $schemaCode;
    protected $_name = [
        'bizObjectId' => 'bizObjectId',
        'schemaCode'  => 'schemaCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizObjectId) {
            $res['bizObjectId'] = $this->bizObjectId;
        }
        if (null !== $this->schemaCode) {
            $res['schemaCode'] = $this->schemaCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return LoadBizObjectRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizObjectId'])) {
            $model->bizObjectId = $map['bizObjectId'];
        }
        if (isset($map['schemaCode'])) {
            $model->schemaCode = $map['schemaCode'];
        }

        return $model;
    }
}
