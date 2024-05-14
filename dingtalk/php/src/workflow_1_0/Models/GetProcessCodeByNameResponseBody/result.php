<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetProcessCodeByNameResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description This parameter is required.
     *
     * Use the UTC time format: yyyy-MM-ddTHH:mmZ
     * @example 2024-03-22T11:50Z
     *
     * @var string
     */
    public $gmtModified;

    /**
     * @description This parameter is required.
     *
     * @example PROC-abcdef-example
     *
     * @var string
     */
    public $processCode;
    protected $_name = [
        'gmtModified' => 'gmtModified',
        'processCode' => 'processCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->gmtModified) {
            $res['gmtModified'] = $this->gmtModified;
        }
        if (null !== $this->processCode) {
            $res['processCode'] = $this->processCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['gmtModified'])) {
            $model->gmtModified = $map['gmtModified'];
        }
        if (isset($map['processCode'])) {
            $model->processCode = $map['processCode'];
        }

        return $model;
    }
}
