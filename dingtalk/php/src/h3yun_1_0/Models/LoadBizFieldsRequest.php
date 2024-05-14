<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models;

use AlibabaCloud\Tea\Model;

class LoadBizFieldsRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example D0001839bbbbe346bbf496498bb76c44c7eb972
     *
     * @var string
     */
    public $schemaCode;
    protected $_name = [
        'schemaCode' => 'schemaCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->schemaCode) {
            $res['schemaCode'] = $this->schemaCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return LoadBizFieldsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['schemaCode'])) {
            $model->schemaCode = $map['schemaCode'];
        }

        return $model;
    }
}
