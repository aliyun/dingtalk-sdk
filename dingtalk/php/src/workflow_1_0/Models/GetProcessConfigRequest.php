<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetProcessConfigRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example PROC-BEFC22B7-EA64-4336-86EB-AB773AA2EB12
     *
     * @var string
     */
    public $procCode;
    protected $_name = [
        'procCode' => 'procCode',
    ];

    public function validate() {}

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
