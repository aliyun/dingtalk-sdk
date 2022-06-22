<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetProcessConfigRequest extends Model
{
    /**
     * @description 模板code
     *
     * @var string
     */
    public $procCode;
    protected $_name = [
        'procCode' => 'procCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->procCode) {
            $res['procCode'] = $this->procCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetProcessConfigRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['procCode'])) {
            $model->procCode = $map['procCode'];
        }

        return $model;
    }
}
